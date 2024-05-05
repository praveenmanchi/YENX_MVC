using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class UielementsController : Controller
{
    private readonly ILogger<UielementsController> _logger;

    public UielementsController(ILogger<UielementsController> logger)
    {
        _logger = logger;
    }


    [Route("/alerts")]
    public IActionResult alerts()
    {
        return View();
    }

    [Route("/badges")]
    public IActionResult badges()
    {
        return View();
    }

    [Route("/breadcrumbs")]
    public IActionResult breadcrumbs()
    {
        return View();
    }

    [Route("/buttongroups")]
    public IActionResult buttongroups()
    {
        return View();
    }

    [Route("/buttons")]
    public IActionResult buttons()
    {
        return View();
    }

    [Route("/cards")]
    public IActionResult cards()
    {
        return View();
    }

    [Route("/dropdowns")]
    public IActionResult dropdowns()
    {
        return View();
    }

    [Route("/images-figures")]
    public IActionResult images_figures()
    {
        return View();
    }

    [Route("/indicators")]
    public IActionResult indicators()
    {
        return View();
    }

    [Route("/listgroups")]
    public IActionResult listgroups()
    {
        return View();
    }

    [Route("/navs-tabs")]
    public IActionResult navs_tabs()
    {
        return View();
    }

    [Route("/object-fit")]
    public IActionResult object_fit()
    {
        return View();
    }

    [Route("/paginations")]
    public IActionResult paginations()
    {
        return View();
    }

    [Route("/popovers")]
    public IActionResult popovers()
    {
        return View();
    }

    [Route("/progress")]
    public IActionResult progress()
    {
        return View();
    }

    [Route("/spinners")]
    public IActionResult spinners()
    {
        return View();
    }

    [Route("/toasts")]
    public IActionResult toasts()
    {
        return View();
    }

    [Route("/tooltips")]
    public IActionResult tooltips()
    {
        return View();
    }
    
}
