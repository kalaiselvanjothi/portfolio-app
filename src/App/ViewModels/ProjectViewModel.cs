using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class ProjectViewModel : BaseViewModel
{
    public ProjectViewModel(PersonalInformation personalInformation, List<Project> projects)
        : base(personalInformation)
    {
        Projects = projects;
    }

    public List<Project> Projects { get; }
}