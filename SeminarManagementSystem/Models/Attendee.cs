using System;
namespace SeminarManagementSystem.Models
{
    public class Attendee
    {
        public int attendeeID { get; set; }
        public string attendee_name { get; set; }
        public DateTime attendee_DOB { get; set; }
        //public int enrolmentSeminarID { get; set; }
        //public EnrolmentSeminar enrolment { get; set; }
    }
}
