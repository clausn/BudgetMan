using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "fill in the fields")]
        public string Name { get; set; }
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "a correct email was not used")]
        public string Email { get; set; }
        [Required(ErrorMessage = "fill in email")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "fill in email")]
        public bool? WillAttend { get; set; }

    }
}