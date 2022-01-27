using System;
using System.ComponentModel.DataAnnotations;

namespace SeminarManagementSystem.Models
{
    public class Attendee
    {
        public int attendeeID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please, enter a name with maximum 50 characteres.")]
        [Display(Name = "Name")]
        public string attendee_name { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime attendee_DOB { get; set; }
    }
}
