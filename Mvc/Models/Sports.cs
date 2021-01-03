using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class Sports
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]///db id için atamalar  1,2,3,4 şeklinde değil de bizim istediğimiz şekilde oldun diye
        public int SportId { get; set; }
        public string SportName { get; set; }
        public string PhotoUrl { get; set; }
        public string InfoSport { get; set; }

    }
}
