using Microsoft.AspNetCore.Mvc;
using MyGreetingsApp.Models;

namespace MyGreetingsApp.Controllers
{
    public class GreetingsController : Controller
    {
        private readonly IConfiguration configuration; // used to read the message from appsettings.json

        public GreetingsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            return View(new GreetingModel()); // empty model, no message shown yet
        }

        [HttpPost]
        public IActionResult ShowGreeting()
        {
            GreetingModel model = new GreetingModel();
            model.Message = configuration["GreetingMessage"]; // reads value from appsettings.json, not hardcoded
            return View("Index", model);
        }
    }
}