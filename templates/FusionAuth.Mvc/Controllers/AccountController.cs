using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

public class AccountController : Controller
{
    public async Task Login(string returnUrl = "/")
    {
        var authenticationProperties = new AuthenticationProperties();
        authenticationProperties.RedirectUri = returnUrl;


        await HttpContext.ChallengeAsync("FusionAuth", authenticationProperties);
    }

    [Authorize]
    public async Task Logout()
    {
        var authenticationProperties = new AuthenticationProperties();
        authenticationProperties.RedirectUri = Url.Action("Index", "Home");

        await HttpContext.SignOutAsync("FusionAuth", authenticationProperties);
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }

    [Authorize]
    public IActionResult Profile()
    {
        return View(User);
    }
}