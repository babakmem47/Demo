using Demo.Models;
using Demo.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class SetadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SetadController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Setad
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var viewModel = new SetadFormViewModel
            {
                IpRanges = _context.IpRanges.ToList(),
                Provinces = _context.Provinces.ToList()
            };
            return View(viewModel);
        }
    }
}