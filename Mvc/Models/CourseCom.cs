using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class CourseCom
    {
        public int Id { get; set; }

        public Courses Courses { get; set; }
        public Comment Comment { get; set; }

    }
}
