using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Murray.Models
{
    public class Patient
    {
        public int patientID { get; set; }
        [Display (Name = "First Name")]
        [Required(ErrorMessage ="Patient first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Patient last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Enter your most frequently used email address")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        public ICollection<Doctor> Doctor { get; set; }
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }

        }
    }
}