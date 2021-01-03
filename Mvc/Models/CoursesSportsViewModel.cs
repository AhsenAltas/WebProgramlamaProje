using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SportProject.Models
{
    public class CoursesSportsViewModel
    {
        public List<Courses> Courses { get; set; }
        public SelectList Sport { get; set; }
        public string CoursesSports { get; set; }
        public string SearchString { get; set; }
    }
}