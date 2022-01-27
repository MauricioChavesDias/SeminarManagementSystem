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
        [Display(Name = "Seminar ID")]
        public int seminarID { get; set; }

        [Display(Name = "Organiser ID")]
        public int organiserID { get; set; }

        [Display(Name = "Type of Seminar ID")]
        public int typeSeminarID { get; set; }

        [Display(Name = "Organiser")]
        public Organiser organiser { get; set; }

        [Display(Name = "Type of Seminar")]
        public TypeSeminar typeSeminar { get; set; }

        [Display(Name = "Title")]
        public string seminar_title { get; set; }

        [Display(Name = "Description")]
        public string seminar_description { get; set; }

        //many
        public virtual EnrolmentSeminar enrolments { get; set; }
    }
}
