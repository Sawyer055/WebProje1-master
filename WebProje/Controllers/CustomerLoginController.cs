using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebProje.Controllers
{
    public class CustomerLoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Login()
        {
            ClaimsPrincipal claimCustomer = HttpContext.User; //if already logged in
            if (claimCustomer.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Customer");
            }
            return View();

        }
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var customeruser = c.Customers.FirstOrDefault(x => x.CustomerEmail == model.Email && x.CustomerPassword == model.Password);
            if (customeruser != null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,model.Email),
                    new Claim("OtherProperties","Role")
                };
                ClaimsIdentity claimscustomerIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = model.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimscustomerIdentity), properties);
                return RedirectToAction("Index", "Customer");
            }
            ViewData["ValidateMessage"] = "Customer not found";
            return View();
            
        }
    }
}
