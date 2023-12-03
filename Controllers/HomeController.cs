using Delievery_Dashboard.Models;
using Delievery_Dashboard.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Delievery_Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(DatesViewModel datesViewModel)
        {
            var model = new CombinedViewModel
            {
                DelieveryDashboard = new DelieveryDashboardModel(),
                TextBox = new TextBoxViewModel()
                //Dates = new List<DatesViewModel> { datesViewModel }, 
            };
            return View(model);
        }

        public IActionResult Submit(CombinedViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.UID = model.TextBox.UID;
                ViewBag.TaskID = model.TextBox.TaskID;
                ViewBag.TaskDescription = model.DelieveryDashboard.TaskDescription;
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return View(model);
            }
            return View();
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