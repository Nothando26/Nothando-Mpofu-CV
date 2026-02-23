using Microsoft.AspNetCore.Mvc;
using MyCV.ViewModel;


public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new CvViewModel
        {
            FullName = "Nothando Mpofu",
            Title = "Final year IT Student, Aspiring Data Analyst",
            Email = "st10440515@myemeris.edu.za",
            Phone = "073 909 5372",

            Profile = "I am a final-year Computer Science student with a strong passion for data analytics and data-driven decision-making. I have skills in programming, statistics, and data visualization, and I enjoy transforming raw data into actionable insights to solve real-world problems.",

            Languages = new List<string> { "Java", "C#", "HTML & CSS", "SQL" },

            Tools = new List<string>
            {
                "MySQL",
                "PostgreSQL",
                "Microsoft SQL Server",
                "MongoDB",
                "Git",
                "GitHub",
                "VS Code"
            },

            Frameworks = new List<string> { "ASP.NET Core" },

            Projects = new List<Project>
            {
                new Project
                {
                    Date = "08/2025 – 11/2025",
                    Name = "Contract Monthly Claim System",
                    Description = "Developed a role-based ASP.NET MVC web application to streamline lecturer claims with authentication, dashboards, and PDF generation."
                }
            },

            Experiences = new List<Experience>
            {
                new Experience
                {
                    Date = "10/2025 – Present",
                    Location = "Roodepoort, Johannesburg",
                    Role = "Arts and Culture Representative",
                    Organization = "Student Life Squad - Emeris University",
                    Description = "Promote student wellbeing, oversee clubs and societies, and plan on- and off-campus events."
                },
                new Experience
                {
                    Date = "11/2025 – 01/2026",
                    Location = "Midrand, Johannesburg",
                    Role = "Part-Time Waitress",
                    Organization = "Nando’s",
                    Description = "Provided customer service in a fast-paced environment while handling orders and payments."
                }
            },

            Education = new Education
            {
                Date = "02/2024 – 12/2026",
                Location = "Roodepoort, South Africa",
                Qualification = "Bachelor’s of Computer and Information Sciences in Application Development",
                Institution = "Emeris University"
            }
        };

        return View(model);
    }
    public IActionResult DownloadCv()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot/files/Nothando-Mpofu-CV.pdf");

        var fileBytes = System.IO.File.ReadAllBytes(filePath);
        return File(fileBytes, "application/pdf", "Nothando-Mpofu-CV.pdf");
    }

}
