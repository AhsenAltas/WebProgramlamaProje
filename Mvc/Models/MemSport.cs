using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class MemSport
    {
        public int Id { get; set; }

        public Sports Sports { get; set; }
        public Member Member { get; set; }

    }
}
