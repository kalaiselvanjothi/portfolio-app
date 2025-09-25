using Microsoft.AspNetCore.Mvc;
using Portfolio.App.Data;
using Portfolio.App.ViewModels;

namespace Portfolio.App.Controllers;

[Route("/")]
public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public IActionResult Index() => View(new IndexViewModel(PortfolioData.PersonalInformation, PortfolioData.Projects, PortfolioData.Skills));

    [HttpGet]
    [Route("error")]
    public IActionResult Error() => View();
}