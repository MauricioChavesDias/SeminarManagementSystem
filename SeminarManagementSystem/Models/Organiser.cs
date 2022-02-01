using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarManagementSystem.Models
{
    public class Organiser
    {

        [Display(Name = "Organiser")]
        public int organiserID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "The organiser name is required.")]
        [StringLength(50, ErrorMessage = "Please, enter a name with maximum 50 characteres.")]
        public string organiser_name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd - MM - yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please, enter a valid date of birth.")]
        public DateTime organiser_DOB { get; set; }
    }
}

