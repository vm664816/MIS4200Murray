using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Murray.Models
{
    public class Payment
    {
        public int paymentID { get; set; }
        [Display(Name = "Date of Payment")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime paymentDate { get; set; }
        [Display(Name = "Payment Amount")]
        [DataType(DataType.Currency)]
        public decimal paymentAmount { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}