using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class AdvanceduiController : Controller
{
    private readonly ILogger<AdvanceduiController> _logger;

    public AdvanceduiController(ILogger<AdvanceduiController> logger)
    {
        _logger = logger;
    }

    [Route("/accordions-collapse")]
    public IActionResult accordions_collapse()
    {
        return View();
    }

    [Route("/draggable-cards")]
    public IActionResult draggable_cards()
    {
        return View();
    }

    [Route("/modals-closes")]
    public IActionResult modals_closes()
    {
        return View();
    }

    [Route("/navbars")]
    public IActionResult navbars()
    {
        return View();
    }

    [Route("/offcanvas")]
    public IActionResult offcanvas()
    {
        return View();
    }

    [Route("/ratings")]
    public IActionResult ratings()
    {
        return View();
    }

    [Route("/scrollspy")]
    public IActionResult scrollspy()
    {
        return View();
    }

    [Route("/swiperjs")]
    public IActionResult swiperjs()
    {
        return View();
    }

    
}
