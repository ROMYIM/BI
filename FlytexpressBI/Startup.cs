using System;
using Application.Services.DataSynchonization;
using Application.Services.DataSynchorization;
using Core.BackgroundService;
using Core.Extensions.DependencyInjection;
using Domain.Schedule.Entities;
using Domain.Schedule.Managers;
using Infrastructure.BackgroundServices;
using Infrastructure.Db.Contexts;
using Infrastructure.Schedule.Factroy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;

namespace FlytexpressBI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region 任务组件注册

            services.AddScoped<DataSynchornizationJob>();
            services.AddSingleton<IJobFactory, ScheduleJobFactory>();
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            services.AddTransient(_ => new ScheduleJob
            {
                Id = 1,
                JobName = "数据定时同步",
                CreationTime = DateTime.Now,
                Status = JobStatus.Init,
                CronExpression = "0/5 * * * * ?",
                Type = new JobType { TypeName = "Domain.Schedule.Managers.DataSynchornizationJob" }
            });

            #endregion

            #region 后台服务组件注册

            services.AddHostedService<StartupService>();
            services.AddSingleton<DataSynchronizationService>();
            services.AddSingleton<IDataSynchorizationService, DataSynchronizationService>(container => container.GetService<DataSynchronizationService>());
            services.AddSingleton<IAutoStartupService, DataSynchronizationService>(container => container.GetService<DataSynchronizationService>());

            #endregion

            #region 数据库组件注册
            services.AddMongoDbContext(Configuration.GetSection("ConnectionStrings:Mongo"));

            services.AddDbContext<IDataSynchronizationDbContxt, FlytBIDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("Npgsql"));
            }, contextLifetime: ServiceLifetime.Singleton, optionsLifetime: ServiceLifetime.Singleton);

            //services.AddEntityFrameworkNpgsql();
            services.AddDbContextPool<FlytBIDbContext>((serviceProvider, options) =>
            {
                options.UseInternalServiceProvider(serviceProvider);
                options.UseNpgsql(Configuration.GetConnectionString("Npgsql"));
                options.EnableSensitiveDataLogging();
            });

            #endregion

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            //app.UseExceptionHandler("/Error");
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
