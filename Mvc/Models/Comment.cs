using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentTxt { get; set; }
        public DateTime SendDate { get; set; }
        public bool ComApproval { get; set; }

        public int CourseId { get; set; }
        public Courses Courses { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
