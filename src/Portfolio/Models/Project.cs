namespace Portfolio.App.Models;

public class Project
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string[] Tags { get; set; } = [];

    public string RepoUrl { get; set; } = string.Empty;

    public string Image { get; set; } = string.Empty;
}