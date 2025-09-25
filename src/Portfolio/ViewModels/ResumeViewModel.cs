using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class ResumeViewModel : BaseViewModel
{
    public ResumeViewModel(PersonalInformation personalInformation, Resume resume)
        : base(personalInformation)
    {
        Resume = resume;
    }

    public Resume Resume { get; }
}
