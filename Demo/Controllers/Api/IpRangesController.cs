using Demo.Dtos;
using Demo.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace Demo.Controllers.Api
{
    public class IpRangesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public IpRangesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<IpRangeDto> GetAll()
        {
            var ipRanges = _context.IpRanges
                .Where(ip => !ip.IsUnused)
                //.Include(ip => ip.Setads)
                .ToList();


            return ipRanges.Select(x => new IpRangeDto
            {
                IprangeId = x.Id,
                Range = x.Range,
                Mask = x.Mask,
                DateCreated = x.DateCreated,
                DateModified = x.DateModified,
                RelatedSetad = _context.Setads.SingleOrDefault(s => s.Id == x.Id).Name
            });
        }
    }
}
