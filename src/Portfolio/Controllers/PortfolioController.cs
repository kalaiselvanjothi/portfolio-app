using Microsoft.AspNetCore.Mvc;
using Portfolio.App.Data;
using Portfolio.App.Models;
using Portfolio.App.ViewModels;

namespace Portfolio.App.Controllers;

[Route("/portfolio")]
public class PortfolioController : Controller
{
    [HttpGet]
    [Route("about")]
    public IActionResult About() => View(new AboutViewModel(PortfolioData.PersonalInformation, PortfolioData.Skills));

    [HttpGet]
    [Route("projects")]
    public IActionResult Project() => View(new ProjectViewModel(PortfolioData.PersonalInformation, PortfolioData.Projects));

    [HttpGet]
    [Route("education")]
    public IActionResult Education() => View(new EducationViewModel(PortfolioData.PersonalInformation, PortfolioData.Educations));

    [HttpGet]
    [Route("certificates")]
    public IActionResult Certificate() => View(new CertificateViewModel(PortfolioData.PersonalInformation, PortfolioData.Certificates));

    [HttpGet]
    [Route("skills")]
    public IActionResult Skill() => View(new SkillViewModel(PortfolioData.PersonalInformation, PortfolioData.Skills));

    [HttpGet]
    [Route("resume")]
    public IActionResult Resume() => View(new ResumeViewModel(PortfolioData.PersonalInformation, PortfolioData.Resume));

    [HttpGet]
    [Route("contact")]
    public IActionResult Contact() => View(new ContactViewModel(PortfolioData.PersonalInformation));

    [HttpPost]
    [Route("contact")]
    public IActionResult Contact([FromForm] ContactRequest request)
    {
        string message;

        if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Message))
        {
            message = "Error: Please ensure all fields are filled out correctly.";
            return View(new ContactViewModel(PortfolioData.PersonalInformation, message, request.Name, isContactFormSubmitted: false));
        }
        else
        {
            message = "Thanks for your message!";
        }

        return View(new ContactViewModel(PortfolioData.PersonalInformation, message, request.Name, isContactFormSubmitted: true));
    }
}