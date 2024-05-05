using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class FormsController : Controller
{
    private readonly ILogger<FormsController> _logger;

    public FormsController(ILogger<FormsController> logger)
    {
        _logger = logger;
    }

    [Route("/form-inputs")]
    public IActionResult form_inputs()
    {
        return View();
    }

    [Route("/form-check-radios")]
    public IActionResult form_check_radios()
    {
        return View();
    }

    [Route("/form-input-groups")]
    public IActionResult form_input_groups()
    {
        return View();
    }

    [Route("/form-select")]
    public IActionResult form_select()
    {
        return View();
    }

    [Route("/form-range")]
    public IActionResult form_range()
    {
        return View();
    }

    [Route("/form-file-uploads")]
    public IActionResult form_file_uploads()
    {
        return View();
    }

    [Route("/form-datetime-pickers")]
    public IActionResult form_datetime_pickers()
    {
        return View();
    }

    [Route("/form-color-pickers")]
    public IActionResult form_color_pickers()
    {
        return View();
    }

    [Route("/form-layouts")]
    public IActionResult form_layouts()
    {
        return View();
    }

    [Route("/quill-editor")]
    public IActionResult quill_editor()
    {
        return View();
    }

    [Route("/form-validations")]
    public IActionResult form_validations()
    {
        return View();
    }

    [Route("/form-select2")]
    public IActionResult form_select2()
    {
        return View();
    }

}
