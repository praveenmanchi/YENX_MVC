using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class TablesController : Controller
{
    private readonly ILogger<TablesController> _logger;

    public TablesController(ILogger<TablesController> logger)
    {
        _logger = logger;
    }


    [Route("/tables")]
    public IActionResult tables()
    {
        return View();
    }

    [Route("/grid-tables")]
    public IActionResult grid_tables()
    {
        return View();
    }

    [Route("/data-tables")]
    public IActionResult data_tables()
    {
        return View();
    }
    
}
