using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class AuthenticationController : Controller
{
    private readonly ILogger<AuthenticationController> _logger;

    public AuthenticationController(ILogger<AuthenticationController> logger)
    {
        _logger = logger;
    }

    [Route("/comingsoon")]
    public IActionResult comingsoon()
    {
        return View("comingsoon","_LayoutAuth");
    }

    [Route("/createpassword-basic")]
    public IActionResult createpassword_basic()
    {
        return View("createpassword_basic","_LayoutError");
    }

    [Route("/createpassword-cover")]
    public IActionResult createpassword_cover()
    {
        return View("createpassword_cover","_LayoutAuth");
    }

    [Route("/lockscreen-basic")]
    public IActionResult lockscreen_basic()
    {
        return View("lockscreen_basic","_LayoutError");
    }

    [Route("/lockscreen-cover")]
    public IActionResult lockscreen_cover()
    {
        return View("lockscreen_cover","_LayoutAuth");
    }

    [Route("/resetpassword-basic")]
    public IActionResult resetpassword_basic()
    {
        return View("resetpassword_basic","_LayoutError");
    }

    [Route("/resetpassword-cover")]
    public IActionResult resetpassword_cover()
    {
        return View("resetpassword_cover","_LayoutAuth");
    }

    [Route("/signup-basic")]
    public IActionResult signup_basic()
    {
        return View("signup_basic","_LayoutError");
    }

    [Route("/signup-cover")]
    public IActionResult signup_cover()
    {
        return View("signup_cover","_LayoutAuth");
    }

    [Route("/signin-basic")]
    public IActionResult signin_basic()
    {
        return View("signin_basic","_LayoutError");
    }

    [Route("/signin-cover")]
    public IActionResult signin_cover()
    {
        return View("signin_cover","_LayoutAuth");
    }

    [Route("/twostep-verification-basic")]
    public IActionResult twostep_verification_basic()
    {
        return View("twostep_verification_basic","_LayoutError");
    }

    [Route("/twostep-verification-cover")]
    public IActionResult twostep_verification_cover()
    {
        return View("twostep_verification_cover","_LayoutAuth");
    }

    [Route("/under-maintenance")]
    public IActionResult under_maintenance()
    {
        return View("under_maintenance","_LayoutAuth");
    }

    
}
