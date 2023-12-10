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

        public IActionResult Index()
        {
            var model = new CombinedViewModel
            {
                DelieveryDashboard = new DelieveryDashboardModel(),
                TextBox = new TextBoxViewModel(),
            };

            return View(model);
        }

        public IActionResult Submit(CombinedViewModel model)
        {
            ViewBag.UID = model.TextBox.UID;
            ViewBag.TaskID = model.TextBox.TaskID;
            ViewBag.TaskDescription = model.DelieveryDashboard.TaskDescription;
            ViewBag.Classification = model.DelieveryDashboard.Classification;
            ViewBag.Complexity = model.DelieveryDashboard.Complexity;
            ViewBag.Resource = model.DelieveryDashboard.Resource;
            ViewBag.Asset = model.DelieveryDashboard.Asset;
            ViewBag.PracticeHead = model.DelieveryDashboard.PracticeHead;
            ViewBag.AccountManager = model.DelieveryDashboard.AccountManager;
            ViewBag.DeliveryManager = model.DelieveryDashboard.DeliveryManager;
            ViewBag.Role = model.DelieveryDashboard.Role;

            if (!ModelState.IsValid)
            {
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