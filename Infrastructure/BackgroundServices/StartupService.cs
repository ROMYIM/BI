using Core.BackgroundService;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.BackgroundServices
{
    public class StartupService : IHostedService
    {
        private readonly ILogger _logger;

        private readonly IEnumerable<IAutoBackgroundService> _services;

        public StartupService(ILoggerFactory loggerFactory, IEnumerable<IAutoBackgroundService> services)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _services = services;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("以后或许由我统一启动所有服务，现在先暂时做个打印");
            foreach (var service in _services)
            {
                _ = service.StartAsync(cancellationToken);
            }
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("启动服务停止");
            return Task.CompletedTask;
        }
    }
}
