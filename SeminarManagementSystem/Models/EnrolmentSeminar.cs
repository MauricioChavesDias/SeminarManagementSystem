using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SeminarManagementSystem.Models
{
    public class EnrolmentSeminar
    {
        public int enrolmentSeminarID { get; set; }


        [DisplayName("Seminar ID")]
        public int seminarID { get; set; }
        [DisplayName("Seminar")]
        public Seminar seminar {  get;set;}


        [DisplayName("Attendee ID")]
        public int attendeeID { get; set; }
        [DisplayName("Attendees")]
        public Attendee attendees { get; set; }



        // many attendees
       // public virtual Attendee attendees { get; set; }
    }
}
