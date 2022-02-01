using System;
using System.ComponentModel.DataAnnotations;

namespace SeminarManagementSystem.Models
{
    public class Attendee
    {
        [Display(Name = "Attendee")]
        public int attendeeID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please, enter the attendee name.")]
        [StringLength(50, ErrorMessage = "Please, enter a name with maximum 50 characteres.")]
        public string attendee_name { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage ="Please, Enter a valid date of birth.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime attendee_DOB { get; set; }

    }
}
