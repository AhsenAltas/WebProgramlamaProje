using Microsoft.AspNetCore.Identity;
using SportProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class Member:IdentityUser
    {

        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [StringLength(20)]////attributes
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        //public City City { get; set; }
        //public Country Country { get; set; }
        public string GetFullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
        ///
        }
}
