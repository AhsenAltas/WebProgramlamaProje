using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class MemMeet
    {
        public int Id { get; set; }
        public Meeting Meeting { get; set; }
        public Member Member { get; set; }
    }
}
