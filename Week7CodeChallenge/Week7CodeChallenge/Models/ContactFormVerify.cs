using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7CodeChallenge.Models
{
    class ContactFormVerify
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNum { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
