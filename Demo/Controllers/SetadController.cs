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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SetadFormViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                viewModel.IpRanges = _context.IpRanges.ToList();
                viewModel.Provinces = _context.Provinces.ToList();

                return View("Create", viewModel);
            }
            var setad = new Setad
            {
                Name = viewModel.Name,
                IpRangeId = viewModel.IpRangeId,
                ProvinceId = viewModel.ProvinceId,
                Shakhes = viewModel.Shakhes,
                Email = viewModel.Email,
                Address = viewModel.Address
            };

            if (viewModel.IsModiriatShoab)
            {
                setad.IsModiriatShoab = true;
            }

            _context.Setads.Add(setad);
            _context.SaveChanges();

            return RedirectToAction("Index", "Setad");
        }
    }
}