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
        [Required(ErrorMessage = "Please, select a valid organiser.")]
        public int organiserID { get; set; }

        [Display(Name = "Seminar Type")]
        [Required(ErrorMessage = "Please, select a valid seminar type.")]
        public int typeSeminarID { get; set; }

        [Display(Name = "Organiser")]
        public Organiser organiser { get; set; }

        //public Organiser organiser_description { get; set; }

        [Display(Name = "Type of Seminar")]
        public TypeSeminar typeSeminar { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Seminar title is required.")]
        [StringLength(40, ErrorMessage = "Please, enter a title with maximum 40 characteres.")]
        public string seminar_title { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Seminar description is required.")]
        [StringLength(100, ErrorMessage = "Please, enter a title with maximum 100 characteres.")]
        public string seminar_description { get; set; }


    }
}
