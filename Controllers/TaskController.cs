using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class TaskController : Controller
{
    private readonly ILogger<TaskController> _logger;

    public TaskController(ILogger<TaskController> logger)
    {
        _logger = logger;
    }


    [Route("/task-kanban-board")]
    public IActionResult task_kanban_board()
    {
        return View();
    }

    [Route("/task-listview")]
    public IActionResult task_listview()
    {
        return View();
    }

    [Route("/task-details")]
    public IActionResult task_details()
    {
        return View();
    }


}
