using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormRegistrator.Models
{
    public class Client : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Registration Date")]
        public DateTime RegistrationDate { get; set; }
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Position")]
        public string Position { get; set; }
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Organisation")]
        public string Organisation { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}