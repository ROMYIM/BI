using Microsoft.Extensions.Hosting;
using System;

namespace FlytexpressBI.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int HttpStatusCode { get; set; } = 500;

        public string ShowerUserMessage { get; set; }

        public string ShowerDeveloperMessage { get; set; }

        public string RequestRoute { get; set; }

        public IHostEnvironment Environment { get; set; }
    }
}
