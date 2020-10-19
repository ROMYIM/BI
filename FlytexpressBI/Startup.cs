using System;
using Application.Queries;
using Application.Services.DataSynchonization;
using Application.Services.DataSynchorization;
using Application.Services.ScheduleJobs;
using AutoMapper;
using Core.BackgroundService;
using Core.Extensions.DependencyInjection;
using Domain.Schedule.Entities;
using FlytexpressBI.Extensions.DependencyInjection;
using Infrastructure.Db.Contexts;
using Infrastructure.Db.Mapper;
using Infrastructure.Schedule.Factroy;
using Infrastructure.Schedule.Service;
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
            #region �ӿ��ĵ�ע��

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("BiApiDoc", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "BI����ӿ�",
                    Description = "���㿪���Ͳ�����Ա����",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Yim",
                        Email = "yanjunrong@flytexpress.com"
                    },
                });
                options.OrderActionsBy(d => d.RelativePath);
            });

            #endregion

            #region ��ѯ����

            services.AddTransient<DataQueryService>();

            #endregion

            #region AutoMapperע��

            services.AddAutoMapper(configuration =>
            {
                configuration.AddProfile<DtoesMapperConfiguration>();
            });

            #endregion

            #region ��ͬ������

            services.AddSynchronizationServices();

            #endregion

            #region �������ע��

            services.AddSingleton<IJobFactory, ScheduleJobFactory>();
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            //services.AddTransient(_ => new ScheduleJob
            //{
            //    Id = 1,
            //    JobName = "���ݶ�ʱͬ��",
            //    CreationTime = DateTime.Now,
            //    Status = JobStatus.Init,
            //    CronExpression = "0/5 * * * * ?",
            //    Type = new JobType { TypeName = "Domain.Schedule.Managers.DataSynchornizationJob" }
            //});

            services.AddQuartz(configurator =>
            {
                configurator.SchedulerName = "base data synchronization scheduler";

                configurator.UseMicrosoftDependencyInjectionScopedJobFactory(options => options.AllowDefaultConstructor = false);
                configurator.AddJob<BaseDataSynchronizationJob>(options => options.WithDescription("��������ͬ��").StoreDurably());

                configurator.UseSimpleTypeLoader();
                configurator.UseDedicatedThreadPool(options => options.MaxConcurrency = 100);
                configurator.UseInMemoryStore();
            });


            #endregion

            #region ��̨�������ע��

            //services.AddHostedService<StartupService>();
            services.AddSingleton<DataSynchronizationService>();
            services.AddSingleton<IScheduleService, DataSynchronizationService>(container => container.GetService<DataSynchronizationService>());
            services.AddSingleton<IAutoStartupService, DataSynchronizationService>(container => container.GetService<DataSynchronizationService>());

            #endregion

            #region ���ݿ����ע��
            services.AddMongoDbContext(Configuration.GetSection("ConnectionStrings:Mongo"));

            //services.AddDbContext<IDataSynchronizationDbContxt, FlytBIDbContext>(options =>
            //{
            //    options.UseNpgsql(Configuration.GetConnectionString("Npgsql"));
            //}, contextLifetime: ServiceLifetime.Singleton, optionsLifetime: ServiceLifetime.Singleton);

            services.AddEntityFrameworkNpgsql();
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

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/BiApiDoc/swagger.json", "BI����ӿ�");
                options.RoutePrefix = "doc";
            });

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
