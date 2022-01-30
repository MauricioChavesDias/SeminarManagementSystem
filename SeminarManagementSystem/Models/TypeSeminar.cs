using System.ComponentModel.DataAnnotations;


namespace SeminarManagementSystem.Models
{
    public class TypeSeminar
    {
        public int typeSeminarID { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Please, enter a title with maximum 40 characteres.")]
        [Display(Name = "Type of Seminar")]
        public string typeSeminar_Title { get; set; }
    }
}
