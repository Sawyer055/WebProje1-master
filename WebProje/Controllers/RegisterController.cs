using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class RegisterController : Controller
    {
        CustomerManager cm=new CustomerManager(new EFICustomer());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Customer customer)
        {
            cm.CustomerAdd(customer);
            return RedirectToAction("Index","Customer");
        }
    }
}
