using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SeminarManagementSystem.Models
{
    public class EnrolmentSeminar
    {

        [Display(Name = "Enrolment ID")]
        public int enrolmentSeminarID { get; set; }

        [Display(Name = "Seminar ID")]
        public int seminarID { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Please, enter a title with maximum 40 characteres.")]
        [Display(Name = "Title")]
        public Seminar seminar {  get;set;}


        [Display(Name = "Attendee ID")]
        public int attendeeID { get; set; }
        [Display(Name = "Attendees")]
        public Attendee attendees { get; set; }



        // many attendees
       // public virtual Attendee attendees { get; set; }
    }
}
