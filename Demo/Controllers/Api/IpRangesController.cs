using Demo.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace Demo.Controllers.Api
{
    public class IpRangesController : ApiController
    {
        private ApplicationDbContext _context;

        public IpRangesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<IpRange> GetAll()
        {
            var ipRanges = _context.IpRanges
                .Where(ip => !ip.IsUnused)
                .Include(ip => ip.Setads)
                .ToList();

            return ipRanges;
        }
    }
}
