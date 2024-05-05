using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    [Route("/")]

    [Route("/index")]
    public IActionResult index()
    {
        return View();
    }

    [Route("/index2")]
    public IActionResult index2()
    {
        return View();
    }

    [Route("/index3")]
    public IActionResult index3()
    {
        return View();
    }

    [Route("/index4")]
    public IActionResult index4()
    {
        return View();
    }

    [Route("/index5")]
    public IActionResult index5()
    {
        return View();
    }

    [Route("/index6")]
    public IActionResult index6()
    {
        return View();
    }

    [Route("/index7")]
    public IActionResult index7()
    {
        return View();
    }

    [Route("/index8")]
    public IActionResult index8()
    {
        return View();
    }

    [Route("/index9")]
    public IActionResult index9()
    {
        return View();
    }

    [Route("/index10")]
    public IActionResult index10()
    {
        return View();
    }

    [Route("/index11")]
    public IActionResult index11()
    {
        return View();
    }

    [Route("/index12")]
    public IActionResult index12()
    {
        return View();
    }

    
}
