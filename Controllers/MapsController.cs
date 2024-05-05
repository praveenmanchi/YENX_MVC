using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class MapsController : Controller
{
    private readonly ILogger<MapsController> _logger;

    public MapsController(ILogger<MapsController> logger)
    {
        _logger = logger;
    }

    [Route("/google-maps")]
    public IActionResult google_maps()
    {
        return View();
    }

    [Route("/leaflet-maps")]
    public IActionResult leaflet_maps()
    {
        return View();
    }

    [Route("/vector-maps")]
    public IActionResult vector_maps()
    {
        return View();
    }
    
}
