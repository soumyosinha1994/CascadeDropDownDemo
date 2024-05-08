using CascadeDropDownDemo.Data;
using CascadeDropDownDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace CascadeDropDownDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //var Countrys = _context.Countries.ToList();

            ViewModelVM viewModelVM = new()
            {
                CountryList = _context.Countries.Select(u => new SelectListItem
                {
                    Text = u.CountryName,
                    Value = u.Id.ToString()
                }),
                Country = new()
            };
           
            return View(viewModelVM);

            //return View(Countrys);
        }
        [HttpGet]
        public IActionResult GetCountry() 
        {
            var Country = _context.Countries.ToList();
            return Json(new SelectList(Country, "Id", "CountryName"));
        }
        [HttpGet]
        public IActionResult GetStates(int Id) 
        { 
        var State=_context.States.Where(x=>x.CountryId==Id).ToList();
            return Json(new SelectList(State, "Id", "StateName"));
        }
        [HttpGet]
        public IActionResult GetCities(int Id) 
        { 
        var City= _context.Cities.Where(x => x.StateId == Id).ToList();
            return Json(new SelectList(City, "Id", "CityName"));
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
