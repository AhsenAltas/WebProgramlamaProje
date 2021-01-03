using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string SiteUrl { get; set; }
        public string InfoCourse { get; set; }
        public DateTime ActTime { get; set; }
        public int SportsId { get; set; }
        public Sports Sports { get; set; }
    }
}