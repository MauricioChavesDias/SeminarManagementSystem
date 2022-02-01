using System.ComponentModel.DataAnnotations;


namespace SeminarManagementSystem.Models
{
    public class TypeSeminar
    {
        [Display(Name = "Seminar Type")]
        public int typeSeminarID { get; set; }

        [Display(Name = "Seminar Type")]
        [Required(ErrorMessage = "Please, enter the seminar title.")]
        [StringLength(40, ErrorMessage = "Please, enter a title with maximum 40 characteres.")]
        public string typeSeminar_Title { get; set; }
    }
}
