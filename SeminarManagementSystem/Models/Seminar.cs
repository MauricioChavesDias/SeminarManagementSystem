using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarManagementSystem.Models
{
    public class Seminar
    {
        //primary key
        public int seminarID { get; set; }
        public int organiserID { get; set; }
        public Organiser organiser { get; set; }
        public int typeSeminarID { get; set; }
        public TypeSeminar type { get; set; }
        public string seminar_title { get; set; }
        public string seminar_description { get; set; }

        //many
        public virtual EnrolmentSeminar enrolments { get; set; }
    }
}
