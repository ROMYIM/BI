using Infrastructure.Caches;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Extensions.DependencyInjection
{
    public static class CacheExtension
    {
        public static IServiceCollection AddDbDtoTypeCaches(this IServiceCollection services)
        {
            services.AddSingleton<PgDtoTypeCaches>();
            return services;
        }
    }
}
