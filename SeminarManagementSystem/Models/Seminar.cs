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
        [Display(Name = "Seminar")]
        public int seminarID { get; set; }

        [Display(Name = "Organiser")]
        public int organiserID { get; set; }

        [Display(Name = "Seminar Type")]
        public int typeSeminarID { get; set; }

        [Display(Name = "Organiser")]
        public Organiser organiser { get; set; }

        //public Organiser organiser_description { get; set; }

        [Display(Name = "Type of Seminar")]
        public TypeSeminar typeSeminar { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Please, enter a title with maximum 40 characteres.")]
        [Display(Name = "Title")]
        public string seminar_title { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please, enter a title with maximum 100 characteres.")]
        [Display(Name = "Description")]
        public string seminar_description { get; set; }


    }
}
