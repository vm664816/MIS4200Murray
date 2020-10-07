using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Murray.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime appointmentDate { get; set; }
        [Display(Name = "Appointment Reason")]
        [Required(ErrorMessage = "A reason for the appointment is required")]
        [StringLength(100)]
        public string appointmentReason { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int paymentID { get; set; }
        public virtual Payment Payment { get; set; }
    }
}