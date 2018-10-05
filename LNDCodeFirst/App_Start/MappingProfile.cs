using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LNDCodeFirst.Dtos;
using LNDCodeFirst.Models;

namespace LNDCodeFirst.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Province, ProvinceDto>();
        }
    }
}