using System;
namespace SeminarManagementSystem.Models
{
    public class EnrolmentSeminar
    {
        public int enrolmentSeminarID { get; set; }
        public Seminar seminar { get; set; }

        // many attendees
        public  virtual Attendee attendees { get; set; }
    }
}
