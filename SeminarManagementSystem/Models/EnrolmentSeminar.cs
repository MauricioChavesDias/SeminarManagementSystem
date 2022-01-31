using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SeminarManagementSystem.Models
{
    public class EnrolmentSeminar
    {

        [Display(Name = "Enrolment")]
        public int enrolmentSeminarID { get; set; }

        [Required]
        [Display(Name = "Seminar")]
        public int seminarID { get; set; }

        [Required]
        [Display(Name = "Attendee")]
        public int attendeeID { get; set; }

        [Display(Name = "Seminar")]
        public Seminar seminar {  get;set;}

        [Display(Name = "Attendee")]
        public Attendee attendee { get; set; }

    }
}
