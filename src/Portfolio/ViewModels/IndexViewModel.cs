using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class IndexViewModel : BaseViewModel
{
    public IndexViewModel(PersonalInformation personalInformation, List<Project> projects, List<Skill> skills)
        : base(personalInformation)
    {
        Projects = projects;
        Skills = skills;
    }

    public List<Project> Projects { get; }

    public List<Skill> Skills { get; }
}
