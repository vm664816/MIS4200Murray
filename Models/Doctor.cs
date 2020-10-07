using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Murray.Models
{
    public class Doctor
    {
        [Key]
        public int doctorID { get; set; }
        [Display(Name = "Doctor First Name")]
        [Required(ErrorMessage = "Doctor first name is required")]
        [StringLength(20)]
        public string doctorFirstName { get; set; }
        [Display(Name = "Doctor Last Name")]
        [Required(ErrorMessage = "Doctor last name is required")]
        [StringLength(20)]
        public string doctorLastName { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public string doctorFullName
        {
            get
            {
                return doctorLastName + ", " + doctorFirstName;
            }
        }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}