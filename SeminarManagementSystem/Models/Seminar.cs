using System;
namespace SeminarManagementSystem.Models
{
    public class Seminar
    {
        //primary key
        public int seminarID { get; set; }
        public Organiser organiser { get; set; }
        public TypeSeminar type { get; set; }
        public string seminar_title { get; set; }
        public string seminar_description { get; set; }

        //many
        public virtual EnrolmentSeminar enrolments { get; set; }
    }
}
