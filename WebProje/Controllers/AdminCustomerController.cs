using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebProje.Controllers
{
    [Authorize]
    public class AdminCustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EFICustomer());
        //RouteManager rm = new RouteManager(new EfIRoute());
		//

		public IActionResult Index()
        {
            var customers = cm.GetList();

            return View(customers);
        }
        [HttpGet]

		public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]

		public IActionResult AddCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                cm.CustomerAdd(customer);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["msj"] = "Ekleme başarısız";

                return View(customer);
            }

        }

		public IActionResult DeleteCustomer(int? id)
        {
            if (id == null)
            {
                return View("CustomerError");
            }
            else
            {
                var customervalue = cm.GetCustomer(id);

                cm.CustomerDelete(customervalue);

                return RedirectToAction("Index");
            }
        }
        [HttpGet]

		public IActionResult EditCustomer(int? id)
        {
            if (id == null || cm == null)
            {
                return NotFound("Error");
            }
            else
            {
                var customervalue = cm.GetCustomer(id);

                return View(customervalue);
            }
        }
        [HttpPost]

		public IActionResult EditCustomer(int? id, Customer customer)
        {
            if (id != customer.CustomerID)
            {
                TempData["hata"] = "ID'ler eşleşmiyor";
                return View("CustomerError");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    cm.CustomerUpdate(customer);

                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["msj"] = "Ekleme başarısız";
                    return View(customer);
                }
            }
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }
        //public IActionResult DetailsCustomer(int? id,Customer customer,EntityLayer.Concrete.Route route)
        //{


        //    if (id != customer.CustomerID || id != route.CustomerID)
        //    {
        //        return NotFound("id eslesmedi");
        //    }
        //    else
        //    {
        //        string customerid = cm.GetCustomer(id).ToString();
        //        string routeid = rm.GetRoute(id).CustomerID.ToString();

        //        if (customerid == routeid)
        //        {
        //            return View();
        //        }
        //        else
        //        {
        //            return NotFound("Error");
        //        }
        //    }
        //}
    }
}
