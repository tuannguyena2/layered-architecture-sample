using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceLayer.Abstractions.Services;
using System.Diagnostics;
using System.Linq;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISADPService _service;

        public HomeController(ILogger<HomeController> logger, ISADPService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            var vm = new TopicViewModel
            {
                Topics = _service.ListAllAvailableTopics().ToList()
            };

            return View(vm);
        }

        public IActionResult Register()
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
