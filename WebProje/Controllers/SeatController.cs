using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class SeatController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var seats=c.Seats.ToList();
            return View(seats);
        }
        [HttpPost]
        public IActionResult Index(int selectedRouteID)
        {
			//var selectedRoute = c.Routes.FirstOrDefault(r => r.RouteID == selectedRouteID);
			//var viewModel = new SeatViewModel
			//{
			//	SelectedRouteID = selectedRouteID,
			//	SelectedRoute = selectedRoute,
			//	Routes = c.Routes.ToList() 
			//};

			return View();
        }
    }
}
