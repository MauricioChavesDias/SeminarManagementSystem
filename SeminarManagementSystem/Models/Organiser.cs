using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarManagementSystem.Models
{
    public class Organiser
    {
        public int organiserID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please, enter a name with maximum 50 characteres.")]
        [Display(Name = "Name")]
        public string organiser_name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime organiser_DOB { get; set; }
    }
}

