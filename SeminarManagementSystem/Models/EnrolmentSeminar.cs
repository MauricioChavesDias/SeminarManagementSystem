using System;
namespace SeminarManagementSystem.Models
{
    public class EnrolmentSeminar
    {
        public int enrolmentSeminarID { get; set; }
        public int seminarID { get; set; }
        public Seminar seminar { get; set; }
        public int attendeeID { get; set; }
        public Attendee attendees { get; set; }

        // many attendees
       // public virtual Attendee attendees { get; set; }
    }
}
