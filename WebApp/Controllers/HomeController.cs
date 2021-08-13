using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ServiceLayer.Abstractions.Services;
using System.Collections.Generic;
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
            var employees = _service.ListAllEmployees();
            var topics = _service.ListAllAvailableTopics();

            var vm = new TopicRegistrationViewModel
            {
                Employees = employees.Select(n => new SelectListItem { Value = n.Id.ToString(), Text = n.Name })?.ToList() ?? new List<SelectListItem>(),
                Topics = topics.Select(n => new SelectListItem { Value = n.Id.ToString(), Text = n.Name })?.ToList() ?? new List<SelectListItem>(),
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Register(TopicRegistrationViewModel vm)
        {
            _service.RegisterAssignment(vm.SelectedEmployee, vm.SelectedSubject);
            return RedirectToAction("Register", "Home");
        }

        public ActionResult GetSubjects(string topicId)
        {
            if (!string.IsNullOrWhiteSpace(topicId))
            {
                var subjects = _service.GetSubjectsByTopic(int.Parse(topicId))
                                       .Select(n => new SelectListItem { Value = n.Id.ToString(), Text = n.Name })?.ToList() ?? new List<SelectListItem>();
                return Json(subjects);
            }

            return null;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
