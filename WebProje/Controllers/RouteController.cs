using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
//using Route = EntityLayer.Concrete.Route;

namespace WebProje.Controllers
{
    public class RouteController : Controller
    {
        RouteManager rm= new RouteManager(new EfIRoute());
        CustomerManager cm=new CustomerManager(new EFICustomer());
        public IActionResult Index()
        {
            var routevalues=rm.GetRoutes();
            return View(routevalues);
        }
        [HttpGet]
        public IActionResult AddRoute()
        {
            List<SelectListItem> routes = (from x in cm.GetList()
                                           select new SelectListItem
                                           {
                                               Text=x.CustomerName,
                                               Value=x.CustomerID.ToString(),

                                           }).ToList();
            ViewBag.vrt=routes;
            return View();
        }
        [HttpPost]
        public IActionResult AddRoute(EntityLayer.Concrete.Route route) 
        {
            rm.RouteAdd(route);
            return RedirectToAction("Index");
        }

        [Route("RouteDelete/{id:int}")]
        public IActionResult DeleteRoute(int id)
        {
            var routevalue = rm.GetRoute(id);

            rm.RouteDelete(routevalue);

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("RouteEdit/{id:int}")]
        public IActionResult EditRoute(int id)
        {
            var routevalue = rm.GetRoute(id);

            return View(routevalue);
        }
        [HttpPost]
        [Route("RouteEdit/{id:int}")]
        public IActionResult EditRoute(EntityLayer.Concrete.Route route)
        {
            rm.RouteUpdate(route);

            return RedirectToAction("Index");
        }
    }
}
