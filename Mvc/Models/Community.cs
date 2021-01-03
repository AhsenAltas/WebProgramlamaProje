using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class Community
    {
        [Key]
        public int ComId { get; set; }
        public string ComName { get; set; }
        public Sports Sports { get; set; }
    }

}
