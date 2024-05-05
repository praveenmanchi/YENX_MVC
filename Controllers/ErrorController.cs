using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class ErrorController : Controller
{
    private readonly ILogger<ErrorController> _logger;

    public ErrorController(ILogger<ErrorController> logger)
    {
        _logger = logger;
    }

    [Route("/error401")]
    public IActionResult error401()
    {
        return View("error401","_LayoutError");
    }

    [Route("/error404")]
    public IActionResult error404()
    {
        return View("error404","_LayoutError");
    }

    [Route("/error500")]
    public IActionResult error500()
    {
        return View("error500","_LayoutError");
    }

    
}
