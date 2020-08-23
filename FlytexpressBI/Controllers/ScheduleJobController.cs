using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Services.DataSynchonization;
using Application.Services.DataSynchorization;
using Core.BackgroundService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlytexpressBI.Controllers
{
    [Route("/schedule/job")]
    [ApiController]
    public class ScheduleJobController : ControllerBase
    {
        private readonly ILogger _logger;

        private readonly IDataSynchorizationService _dataSyncService;

        public ScheduleJobController(
            ILoggerFactory loggerFactory,
            DataSynchronizationService dataSynchronizationService)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _dataSyncService = dataSynchronizationService;
        }

        [Route("stop")]
        public async Task<IActionResult> Stop()
        {
            var tokenSource = new CancellationTokenSource();
            await _dataSyncService?.StopAsync(tokenSource.Token);
            _logger.LogDebug("停止任务");
            return Ok("停止任务成功");
        }

        [Route("restart")]
        public IActionResult Restart()
        {
            var delaySpan = TimeSpan.FromSeconds(10);
            var tokenSource = new CancellationTokenSource();
             _dataSyncService.RestartAsync(delaySpan, tokenSource.Token);
            return RedirectToAction(actionName: "index", controllerName: "home");
        }
    }
}
