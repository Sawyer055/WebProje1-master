using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using EntityLayer.Concrete;
using DataAccessLayer.Concrete;

namespace WebProje.Controllers
{
    public class AccessController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Login()
        {
            ClaimsPrincipal claimAdmin = HttpContext.User; //if already logged in
            if(claimAdmin.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "AdminCustomer");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) //-------->LoginViewModeli Admin admin ile değiştir
        {
            var adminuser = c.Admins.FirstOrDefault(x => x.AdminEmail == model.Email && x.AdminPassword == model.Password);
            if (adminuser != null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,model.Email),
                    new Claim("OtherProperties","Role")
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = model.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);
                return RedirectToAction("Index","AdminCustomer");
            }
            ViewData["ValidateMessage"] = "Admin not found";
            return View();
        }
    }
}
