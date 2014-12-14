using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week7CodeChallenge.Models
{
    [MetadataType(typeof(ContactFormVerify))]
    public partial class AJAXContactForm
    {
        
    }
    class ContactFormVerify
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required, Display(Name = "Phone Number")]
        public string PhoneNum { get; set; }
        [Required, Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required, Display(Name = "Project Description")]
        public string ProjectDescription { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
