using Demo.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Demo.Dtos;

namespace Demo.Controllers.Api
{
    public class SetadsController : ApiController
    {
        private ApplicationDbContext _context;

        public SetadsController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<SetadDto> GetAllSetads()
        {
            var setads = _context.Setads
                .Include(s => s.IpRange)
                .Include(s => s.Province)
                .ToList();

            return setads.Select(s => new SetadDto
            {
                Id = s.Id,
                Name = s.Name,
                IpRange = new IpRangeDto
                {
                    Range = s.IpRange.Range,
                    Mask = s.IpRange.Mask
                },
                Shakhes = s.Shakhes,
                Email = s.Email,
                Province = new ProvinceDto
                {
                    Center = (s.ProvinceId != null) ? s.Province.CityCenter : "",
                    Name = (s.ProvinceId != null) ? s.Province.ProvinceName : "",
                    PreTel = (s.ProvinceId != null) ? s.Province.PreTelCode : ""
                },
                Address = s.Address,
                IsModiriatShoab = s.IsModiriatShoab
            });
        }
    }
}
