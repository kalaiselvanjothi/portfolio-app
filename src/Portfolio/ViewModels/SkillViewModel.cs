using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class SkillViewModel : BaseViewModel
{
    public SkillViewModel(PersonalInformation personalInformation, List<Skill> skills)
        : base(personalInformation)
    {
        Skills = skills;
    }

    public List<Skill> Skills { get; }
}