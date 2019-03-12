using Demo.Dtos;
using Demo.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

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
                .Where(s => s.IsDeleted != true)
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

        [HttpDelete]
        public IHttpActionResult DeleteSetad(int id)
        {
            //var currentUserId = User.Identity.GetUserId();
            var setad = _context.Setads.Single(s => s.Id == id);

            setad.IsDeleted = true;
            _context.SaveChanges();

            return Ok("Record '" + setad.Name + "' Logically Deleted Successfully");
        }
    }
}
