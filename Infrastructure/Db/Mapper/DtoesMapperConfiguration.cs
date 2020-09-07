using AutoMapper;
using Infrastructure.Db.Dtoes.Mongo.Bill;
using Infrastructure.Db.Dtoes.Pg;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Mapper
{
    public class DtoesMapperConfiguration : Profile
    {
        public DtoesMapperConfiguration()
        {
            //CreateMap<UserMoneyRecord, Usermoneyrecord>();
        }
    }
}
