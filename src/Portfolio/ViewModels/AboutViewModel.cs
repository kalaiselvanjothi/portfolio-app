using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class AboutViewModel : BaseViewModel
{
    public AboutViewModel(PersonalInformation personalInformation, List<Skill> skills)
        : base(personalInformation)
    {
        Skills = skills;
    }

    public List<Skill> Skills { get; }
}
