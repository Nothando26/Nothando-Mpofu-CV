
using System.Collections.Generic;

namespace MyCV.ViewModel
{
    public class CvViewModel
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Profile { get; set; }

        public List<string> Languages { get; set; }
        public List<string> Tools { get; set; }
        public List<string> Frameworks { get; set; }

        public List<Experience> Experiences { get; set; }
        public List<Project> Projects { get; set; }

        public Education Education { get; set; }
    }

    public class Experience
    {
        public string Date { get; set; }
        public string Location { get; set; }
        public string Role { get; set; }
        public string Organization { get; set; }
        public string Description { get; set; }
    }

    public class Project
    {
        public string Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Education
    {
        public string Date { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public string Institution { get; set; }
    }
}

