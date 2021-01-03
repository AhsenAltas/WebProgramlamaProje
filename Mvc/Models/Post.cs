using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string FotoUrl { get; set; }
        public string Text { get; set; }
        public DateTime PostDate { get; set; }

        public Comment Comment { get; set; }
        public Sports Sport { get; set; }
        public Member Member { get; set; }
    }
}
