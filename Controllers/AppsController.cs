using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ynex.Models;

namespace ynex.Controllers;

public class AppsController : Controller
{
    private readonly ILogger<AppsController> _logger;

    public AppsController(ILogger<AppsController> logger)
    {
        _logger = logger;
    }

    [Route("/full-calendar")]
    public IActionResult full_calendar()
    {
        return View();
    }

    [Route("/gallery")]
    public IActionResult gallery()
    {
        return View();
    }

    [Route("/projects-list")]
    public IActionResult projects_list()
    {
        return View();
    }

    [Route("/projects-overview")]
    public IActionResult projects_overview()
    {
        return View();
    }

    [Route("/projects-create")]
    public IActionResult projects_create()
    {
        return View();
    }

    [Route("/job-details")]
    public IActionResult job_details()
    {
        return View();
    }

    [Route("/job-company-search")]
    public IActionResult job_company_search()
    {
        return View();
    }

    [Route("/job-search")]
    public IActionResult job_search()
    {
        return View();
    }

    [Route("/job-post")]
    public IActionResult job_post()
    {
        return View();
    }

    [Route("/job-list")]
    public IActionResult job_list()
    {
        return View();
    }

    [Route("/job-candidate-search")]
    public IActionResult job_candidate_search()
    {
        return View();
    }

    [Route("/job-candidate-details")]
    public IActionResult job_candidate_details()
    {
        return View();
    }

    [Route("/nft-marketplace")]
    public IActionResult nft_marketplace()
    {
        return View();
    }

    [Route("/nft-details")]
    public IActionResult nft_details()
    {
        return View();
    }

    [Route("/nft-create")]
    public IActionResult nft_create()
    {
        return View();
    }

    [Route("/nft-wallet-integration")]
    public IActionResult nft_wallet_integration()
    {
        return View();
    }

    [Route("/nft-live-auction")]
    public IActionResult nft_live_auction()
    {
        return View();
    }

    [Route("/crm-contacts")]
    public IActionResult crm_contacts()
    {
        return View();
    }

    [Route("/crm-companies")]
    public IActionResult crm_companies()
    {
        return View();
    }

    [Route("/crm-deals")]
    public IActionResult crm_deals()
    {
        return View();
    }

    [Route("/crm-leads")]
    public IActionResult crm_leads()
    {
        return View();
    }

    [Route("/crypto-transactions")]
    public IActionResult crypto_transactions()
    {
        return View();
    }

    [Route("/crypto-currency-exchange")]
    public IActionResult crypto_currency_exchange()
    {
        return View();
    }

    [Route("/crypto-buysell")]
    public IActionResult crypto_buysell()
    {
        return View();
    }

    [Route("/crypto-marketcap")]
    public IActionResult crypto_marketcap()
    {
        return View();
    }

    [Route("/crypto-wallet")]
    public IActionResult crypto_wallet()
    {
        return View();
    }

}
