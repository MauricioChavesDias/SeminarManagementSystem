using System.ComponentModel.DataAnnotations;


namespace SeminarManagementSystem.Models
{
    public class TypeSeminar
    {
        [Display(Name = "Seminar Type")]
        public int typeSeminarID { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Please, enter a title with maximum 40 characteres.")]
        [Display(Name = "Seminar Type")]
        public string typeSeminar_Title { get; set; }
    }
}
