using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using LNDCodeFirst.Dtos;
using LNDCodeFirst.Models;

namespace LNDCodeFirst.Controllers.Api
{
    public class ProvincesController : ApiController
    {
        private ApplicationDbContext _db;

        public ProvincesController()
        {
            _db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }

        // GET          /api/provinces/             Read All
        public IHttpActionResult GetProvince()
        {
            var provinceDtoList = _db.Provinces.ToList().Select(Mapper.Map<Province, ProvinceDto>);
            return Ok(provinceDtoList);
        }
    }
}
