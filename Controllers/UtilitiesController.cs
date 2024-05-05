using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class UtilitiesController : Controller
{
    private readonly ILogger<UtilitiesController> _logger;

    public UtilitiesController(ILogger<UtilitiesController> logger)
    {
        _logger = logger;
    }


    [Route("/avatars")]
    public IActionResult avatars()
    {
        return View();
    }

    [Route("/borders")]
    public IActionResult borders()
    {
        return View();
    }

    [Route("/colors")]
    public IActionResult colors()
    {
        return View();
    }

    [Route("/columns")]
    public IActionResult columns()
    {
        return View();
    }

    [Route("/flex")]
    public IActionResult flex()
    {
        return View();
    }

    [Route("/grids")]
    public IActionResult grids()
    {
        return View();
    }

}
