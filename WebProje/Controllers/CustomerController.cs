using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using Route = EntityLayer.Concrete.Route;

namespace WebProje.Controllers
{
	[Authorize]
	public class CustomerController : Controller
	{
		
		[HttpGet]
		public IActionResult Index()
		{
			RouteManager rm = new RouteManager(new EfIRoute());
			var routes=rm.GetRoutes();

			return View(routes);
		}
        [HttpPost]
        public IActionResult Index(Route route)
        {
           if(ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}
        }
    }
}
