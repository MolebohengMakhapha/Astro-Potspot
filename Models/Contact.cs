using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _219014430.Models
{
    public class Contact
    {
        [Key]
        public string ContactId { get; set; }

        [Display(Name = "Full Name and Surname")]
        [Required(ErrorMessage = "Fullname is Required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Your name may not be less than 2 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$")]
        [StringLength(70)]
        [Display(Name = "Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Your Message")]
        public string Message { get; set; }
    }
}