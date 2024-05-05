using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class ChartsController : Controller
{
    private readonly ILogger<ChartsController> _logger;

    public ChartsController(ILogger<ChartsController> logger)
    {
        _logger = logger;
    }

    [Route("/apex-line-charts")]
    public IActionResult apex_line_charts()
    {
        return View();
    }

    [Route("/apex-area-charts")]
    public IActionResult apex_area_charts()
    {
        return View();
    }

    [Route("/apex-column-charts")]
    public IActionResult apex_column_charts()
    {
        return View();
    }

    [Route("/apex-bar-charts")]
    public IActionResult apex_bar_charts()
    {
        return View();
    }

    [Route("/apex-mixed-charts")]
    public IActionResult apex_mixed_charts()
    {
        return View();
    }

    [Route("/apex-rangearea-charts")]
    public IActionResult apex_rangearea_charts()
    {
        return View();
    }

    [Route("/apex-timeline-charts")]
    public IActionResult apex_timeline_charts()
    {
        return View();
    }

    [Route("/apex-candlestick-charts")]
    public IActionResult apex_candlestick_charts()
    {
        return View();
    }

    [Route("/apex-boxplot-charts")]
    public IActionResult apex_boxplot_charts()
    {
        return View();
    }

    [Route("/apex-bubble-charts")]
    public IActionResult apex_bubble_charts()
    {
        return View();
    }

    [Route("/apex-scatter-charts")]
    public IActionResult apex_scatter_charts()
    {
        return View();
    }

    [Route("/apex-heatmap-charts")]
    public IActionResult apex_heatmap_charts()
    {
        return View();
    }

    [Route("/apex-treemap-charts")]
    public IActionResult apex_treemap_charts()
    {
        return View();
    }

    [Route("/apex-pie-charts")]
    public IActionResult apex_pie_charts()
    {
        return View();
    }

    [Route("/apex-radialbar-charts")]
    public IActionResult apex_radialbar_charts()
    {
        return View();
    }

    [Route("/apex-radar-charts")]
    public IActionResult apex_radar_charts()
    {
        return View();
    }

    [Route("/apex-polararea-charts")]
    public IActionResult apex_polararea_charts()
    {
        return View();
    }

    [Route("/chartjs-charts")]
    public IActionResult chartjs_charts()
    {
        return View();
    }
    
    [Route("/chartjs")]
    public IActionResult chartjs()
    {
        return View();
    }
    
    [Route("/echarts")]
    public IActionResult echarts()
    {
        return View();
    }

}
