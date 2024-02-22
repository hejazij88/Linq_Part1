using Linq_Performance.Services;
using Microsoft.AspNetCore.Mvc;

namespace Linq_Performance.Controllers
{
    public class UserController : Controller
    {
        private readonly UserServices Services;

        public UserController(UserServices userServices)
        {
            Services = userServices;
        }
        public ActionResult Index()
        {
            return View(Services.SkipAndTake());
        }

    }
}
