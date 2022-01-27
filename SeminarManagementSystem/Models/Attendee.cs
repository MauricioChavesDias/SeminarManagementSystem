using System;
using System.ComponentModel.DataAnnotations;

namespace SeminarManagementSystem.Models
{
    public class Attendee
    {
        public int attendeeID { get; set; }
        public string attendee_name { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime attendee_DOB { get; set; }
    }
}
