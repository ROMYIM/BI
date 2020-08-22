using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlytexpressBI.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FlytexpressBI.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger _logger;

        private readonly IHostEnvironment _enviroment;

        public ErrorController(ILoggerFactory loggerFactory, IHostEnvironment hostEnvironment)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _enviroment = hostEnvironment;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return View(viewName: "Error", HandleError());
        }

        private ErrorViewModel HandleError()
        {
            var model = new ErrorViewModel();

            var errorFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            var error = errorFeature?.Error;
            model.ShowerDeveloperMessage = BuildDeveloperErrorMessage();
            if (error is ApplicationException)
            {
                model.ShowerUserMessage = error.Message;
            }

            var requestPath = errorFeature?.Path ?? HttpContext.Features.Get<IStatusCodeReExecuteFeature>()?.OriginalPath;
            model.RequestRoute = requestPath;
            model.Environment = _enviroment;
            model.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            model.HttpStatusCode = HttpContext.Response.StatusCode;
            return model;

            string BuildDeveloperErrorMessage()
            {
                if (error == null) return "请刷新页面或重新请求";

                var messageStack = new Stack<string>();
                messageStack.Push(error.StackTrace);
                var innerError = error.InnerException;
                while (innerError != null)
                {
                    messageStack.Push(innerError.StackTrace);
                    innerError = innerError.InnerException;
                }

                var developerMessageBuilder = new StringBuilder();
                while (messageStack.Count > 0)
                {
                    developerMessageBuilder.Append(messageStack.Pop());
                }
                return developerMessageBuilder.ToString();
            }
        }
    }
}
