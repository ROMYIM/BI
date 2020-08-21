using Core.DataBase.Mongo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions.DependencyInjection
{
    public static class MongoExtension
    {
        public static IServiceCollection AddMongoDbContext(this IServiceCollection services, Action<MongoDbOptions> configureOptions)
        {
            if (configureOptions == null) throw new ArgumentNullException(nameof(configureOptions));
            services.Configure(configureOptions);

            services.AddSingleton<MongoDbContext>();
            return services;
        }

        public static IServiceCollection AddMongoDbContext(this IServiceCollection services, IConfiguration mongoDbOptions)
        {
            services.Configure<MongoDbOptions>(mongoDbOptions);

            services.AddSingleton<MongoDbContext>();
            return services;
        }
    }
}
