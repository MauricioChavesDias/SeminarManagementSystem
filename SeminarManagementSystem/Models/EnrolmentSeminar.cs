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

        [Display(Name = "Seminar")]
        [Required(ErrorMessage = "Please, select a valid seminar.")]
        public int seminarID { get; set; }

        [Display(Name = "Attendee")]
        [Required(ErrorMessage = "Please, select a valid attendee.")]
        public int attendeeID { get; set; }

        [Display(Name = "Seminar")]
        public Seminar seminar {  get;set;}

        [Display(Name = "Attendee")]
        public Attendee attendee { get; set; }

    }
}
