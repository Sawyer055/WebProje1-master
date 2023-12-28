using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
	[Authorize]
	public class CustomerController : Controller
	{RouteManager rm = new RouteManager(new EfIRoute());
		public IActionResult Index()
		{
            var routes=rm.GetRoutes();
            return View(routes);
		}
        [HttpPost]
        public IActionResult Index(Route route)
        {
            var routes = rm.GetRoutes();
            return View(routes);
        }
    }
}
