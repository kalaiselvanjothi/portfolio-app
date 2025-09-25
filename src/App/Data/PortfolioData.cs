using Portfolio.App.Models;

namespace Portfolio.App.Data;

public static class PortfolioData
{
    public static readonly PersonalInformation PersonalInformation = new()
    {
        Name = "Kalaiselvan Jothi",
        Email = "kalaiselvanjothi39@gmail.com",
        Phone = "+91 8610244243",
        LinkedIn = "https://www.linkedin.com/in/kalaiselvanjothi",
        GitHub = "https://github.com/kalaiselvanjothi",
        Location = "Chennai, Tamil Nadu, India",
        ProfileImageUrl = "/img/profile-photo.jpeg",
        Bio = "Aspiring Software Developer skilled in C#, ASP.NET Core, Angular, and PostgreSQL. Passionate about building efficient and scalable web applications. Eager to contribute to innovative projects and grow in a dynamic tech environment.",
        Title = "Software Developer | C# | ASP.NET Core | Angular | PostgreSQL | Web Applications"
    };

    public static readonly List<Project> Projects = new()
    {
        new Project
        {
            Title = "To Do App",
            Description = "Responsive to‑do app with smooth animations, CRUD tasks, and persistent storage.",
            Tags = new[] { "HTML", "CSS", "JavaScript" },
            RepoUrl = "https://github.com/kalaiselvanjothi/todo-app.git",
            Image = "/img/todo-app-project-logo.png"
        },
        new Project
        {
            Title = "Hospital Management System",
            Description = "C# backend automation, PostgreSQL integration, and clean MVC UI.",
            Tags = new[] { "C#", "ASP.NET Core", "WPF", "PostgreSQL" },
            RepoUrl = "https://github.com/kalaiselvanjothi/hospital-management-system.git",
            Image = "/img/hospital-management-system-project-logo.png"
        }
    };

    public static readonly List<Skill> Skills = new()
    {
        new Skill { Name = "ASP.NET Core MVC", LogoPath = "~/img/aspnetcoremvc-logo.png", Category = "Backend" },
        new Skill { Name = ".NET Core", LogoPath = "~/img/dotnet-logo.png", Category = "Backend" },
        new Skill { Name = "C#", LogoPath = "~/img/csharp-logo.png", Category = "Backend" },
        new Skill { Name = "Angular", LogoPath = "~/img/angular-logo.png", Category = "Frontend" },
        new Skill { Name = "TypeScript", LogoPath = "~/img/typescript-logo.png", Category = "Frontend" },
        new Skill { Name = "JavaScript", LogoPath = "~/img/javascript-logo.png", Category = "Frontend" },
        new Skill { Name = "Bootstrap", LogoPath = "~/img/bootstrap-logo.png", Category = "Frontend" },
        new Skill { Name = "CSS", LogoPath = "~/img/css-logo.png", Category = "Frontend" },
        new Skill { Name = "HTML", LogoPath = "~/img/html-logo.png", Category = "Frontend" },
        new Skill { Name = "PostgreSQL", LogoPath = "~/img/postgresql-logo.png", Category = "Database" },
        new Skill { Name = "Git ", LogoPath = "~/img/git-logo.png", Category = "Tools" },
        new Skill { Name = "GitHub ", LogoPath = "~/img/github-logo.png", Category = "Tools" },
    };

    public static readonly List<Certificate> Certificates = new()
    {
        new Certificate
        {
            Title = "Foundational of C#",
            Issuer = "Microsoft",
            IssuedDate = new DateTime(2025, 3, 1),
            CertificateUrl = "https://www.freecodecamp.org/certification/fcceab7a2fc-3c7c-439c-9e94-9d8a6d282241/foundational-c-sharp-with-microsoft"
        },
        new Certificate
        {
            Title = "Back-End Development with .NET",
            Issuer = "Microsoft",
            IssuedDate = new DateTime(2025, 8, 6),
            CertificateUrl = "https://coursera.org/verify/0KL1PFZDCNDK"
        },
        new Certificate
        {
            Title = "Programming with JavaScript",
            Issuer = "Meta",
            IssuedDate = new DateTime(2025, 8, 4),
            CertificateUrl = "https://coursera.org/share/08616be4831769f38559eaa8d31d3d3e"
        },
        new Certificate
        {
            Title = "SQL and Relational Databases 101",
            Issuer = "IBM",
            IssuedDate = new DateTime(2023, 7, 4),
            CertificateUrl = "https://courses.cognitiveclass.ai/certificates/5f4bbf4a0e184fa0a82c8327e509a0f4"
        },
        new Certificate
        {
            Title = "PostgreSQL: Become an SQL Developer",
            Issuer = "Simplilearn",
            IssuedDate = new DateTime(2025, 8, 8),
            CertificateUrl = "https://simpli-web.app.link/e/UmrZw9DI5Vb"
        }
    };

    public static readonly List<Education> Educations = new()
    {
        new Education
        {
            CourseOfStudy = "B.E. Electronics and Communication Engineering",
            Institution = "Anna University, Villupuram",
            Duration = "2020 - 2024",
            Percentage = 76.8f
        },
        new Education
        {
            CourseOfStudy = "HSC",
            Institution = "Government Boys Higher Secondary School, Perperiyankuppam",
            Duration = "2020",
            Percentage = 62.1f
        },
        new Education
        {
            CourseOfStudy = "SSLC",
            Institution = "Government Boys Higher Secondary School, Perperiyankuppam",
            Duration = "2018",
            Percentage = 77.4f
        }
    };
    
    public static readonly Resume Resume = new()
    {
        ResumeUrl = "/docs/resume.pdf",
        LastUpdated = new DateTime(2025, 9, 26)
    };
}
