using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class PagesController : Controller
{
    private readonly ILogger<PagesController> _logger;

    public PagesController(ILogger<PagesController> logger)
    {
        _logger = logger;
    }


    [Route("/aboutus")]
    public IActionResult aboutus()
    {
        return View();
    }

    [Route("/blog")]
    public IActionResult blog()
    {
        return View();
    }

    [Route("/blog-details")]
    public IActionResult blog_details()
    {
        return View();
    }

    [Route("/blog-create")]
    public IActionResult blog_create()
    {
        return View();
    }

    [Route("/chat")]
    public IActionResult chat()
    {
        return View();
    }

    [Route("/contacts")]
    public IActionResult contacts()
    {
        return View();
    }

    [Route("/contactus")]
    public IActionResult contactus()
    {
        return View();
    }

    [Route("/add-products")]
    public IActionResult add_products()
    {
        return View();
    }

    [Route("/cart")]
    public IActionResult cart()
    {
        return View();
    }

    [Route("/checkout")]
    public IActionResult checkout()
    {
        return View();
    }

    [Route("/edit-products")]
    public IActionResult edit_products()
    {
        return View();
    }

    [Route("/order-details")]
    public IActionResult order_details()
    {
        return View();
    }

    [Route("/orders")]
    public IActionResult orders()
    {
        return View();
    }

    [Route("/products")]
    public IActionResult products()
    {
        return View();
    }

    [Route("/products-details")]
    public IActionResult products_details()
    {
        return View();
    }

    [Route("/products-list")]
    public IActionResult products_list()
    {
        return View();
    }

    [Route("/wishlist")]
    public IActionResult wishlist()
    {
        return View();
    }

    [Route("/mail")]
    public IActionResult mail()
    {
        return View();
    }

    [Route("/mail-settings")]
    public IActionResult mail_settings()
    {
        return View();
    }

    [Route("/empty-page")]
    public IActionResult empty_page()
    {
        return View();
    }

    [Route("/faqs")]
    public IActionResult faqs()
    {
        return View();
    }

    [Route("/filemanager")]
    public IActionResult filemanager()
    {
        return View();
    }

    [Route("/invoice-create")]
    public IActionResult invoice_create()
    {
        return View();
    }

    [Route("/invoice-details")]
    public IActionResult invoice_details()
    {
        return View();
    }

    [Route("/invoice-list")]
    public IActionResult invoice_list()
    {
        return View();
    }

    [Route("/landing")]
    public IActionResult landing()
    {
        return View("landing","_LayoutLan");
    }

    [Route("/landing-jobs")]
    public IActionResult landing_jobs()
    {
       return View("landing_jobs","_LayoutLanjobs");
    }

    [Route("/notifications")]
    public IActionResult notifications()
    {
        return View();
    }

    [Route("/pricing")]
    public IActionResult pricing()
    {
        return View();
    }

    [Route("/profile")]
    public IActionResult profile()
    {
        return View();
    }

    [Route("/reviews")]
    public IActionResult reviews()
    {
        return View();
    }

    [Route("/team")]
    public IActionResult team()
    {
        return View();
    }

    [Route("/terms")]
    public IActionResult terms()
    {
        return View();
    }

    [Route("/timeline")]
    public IActionResult timeline()
    {
        return View();
    }
    
    [Route("/todo")]
    public IActionResult todo()
    {
        return View();
    }

}
