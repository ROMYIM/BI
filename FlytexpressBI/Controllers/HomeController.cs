using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FlytexpressBI.Models;
using Core.DataBase.Mongo;
using Infrastructure.Db.Contexts;
using Infrastructure.Db.Dotes.Mongo.OrderEntity;

namespace FlytexpressBI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MongoDbContext _mongoDbContext;

        private readonly FlytBIDbContext _flytBIDbContext;

        public HomeController(ILogger<HomeController> logger, MongoDbContext mongo, FlytBIDbContext flytBIDb)
        {
            _logger = logger;
            _mongoDbContext = mongo;
            _flytBIDbContext = flytBIDb;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("hello");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public OrderParent Order()
        {
            var order = _mongoDbContext.FirstOrDefault<OrderParent>(o => o.Id == "F802672006160004");
            return order;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
