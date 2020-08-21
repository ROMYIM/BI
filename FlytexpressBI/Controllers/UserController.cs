using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataBase.Mongo;
using Infrastructure.Db.Contexts;
using Infrastructure.Db.Dtoes.Mongo.Authorization.UserRolePermission;
using Infrastructure.Db.Dtoes.Pg;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;

namespace FlytexpressBI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger _logger;

        private readonly MongoDbContext _mongoContext;

        private readonly FlytBIDbContext _flytBIDbContext;

        public UserController(ILoggerFactory loggerFactory, MongoDbContext mongoContext, FlytBIDbContext flytBIDb)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _mongoContext = mongoContext;
            _flytBIDbContext = flytBIDb;
        }

        public async ValueTask<User> Index(int id = 33324)
        {
            var pgUser = await _flytBIDbContext.Users.FindAsync(id) ?? new User();
            var user = _mongoContext.FirstOrDefault<Users>(u => u.Id == id);
            if (user != null)
            {
                pgUser.Id = user.Id;
                pgUser.IsDeleted = user.IsDeleted;
                pgUser.Permissions = user.Permissions.ToJson();
                pgUser.UserName = user.UserName;
                pgUser.Roleds = user.RoleIds.ToJson();

                await _flytBIDbContext.Users.AddAsync(pgUser);
            }
            return pgUser;
        }
    }
}
