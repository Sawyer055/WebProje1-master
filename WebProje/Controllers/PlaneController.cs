using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebProje.Controllers
{
    public class PlaneController : Controller
    {
        RouteManager rm = new RouteManager(new EfIRoute());
        PlaneManager pm=new PlaneManager(new EfIPlane());
        public IActionResult Index()
        {
            var routevalues = pm.GetPlanes();
            return View(routevalues);
        }
        [HttpGet]
        public IActionResult AddPlane()
        {
            List<SelectListItem> planes = (from x in rm.GetRoutes()
                                           select new SelectListItem
                                           {
                                               Text = x.RouteName,
                                               Value = x.RouteID.ToString(),

                                           }).ToList();
            ViewBag.vrt = planes;
            return View();
        }
        [HttpPost]
        public IActionResult AddPlane(Plane plane)
        {
            pm.PlaneAdd(plane);
            return RedirectToAction("Index");
        }

        [Route("PlaneDelete/{id:int}")]
        public IActionResult DeletePlane(int id)
        {
            var planevalue = pm.GetPlane(id);

            pm.PlaneDelete(planevalue);

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("PlaneEdit/{id:int}")]
        public IActionResult EditPlane(int id)
        {
            var planevalue = pm.GetPlane(id);

            return View(planevalue);
        }
        [HttpPost]
        [Route("PlaneEdit/{id:int}")]
        public IActionResult EditPlane(Plane plane)
        {
            pm.PlaneUpdate(plane);

            return RedirectToAction("Index");
        }
    }
}
