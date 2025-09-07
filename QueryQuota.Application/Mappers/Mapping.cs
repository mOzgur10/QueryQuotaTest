using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using QueryQuota.Application.DTOs;
using QueryQuota.CORE.Entities;

namespace QueryQuota.Application.Mappers
{
    public class Mapping: Profile
    {
        public Mapping() {

            CreateMap<QueryLog, QueryLogDTO>()
                .ReverseMap();
            CreateMap<MyData, MyDataDTO>()
                .ReverseMap();
           
        }
    }
}
