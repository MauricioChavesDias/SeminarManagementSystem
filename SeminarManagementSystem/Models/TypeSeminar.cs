using System.ComponentModel.DataAnnotations;


namespace SeminarManagementSystem.Models
{
    public class TypeSeminar
    {
        public int typeSeminarID { get; set; }

        [StringLength(30, ErrorMessage = "Please, enter a title with maximum 30 characteres.")]
        [Display(Name = "Title")]
        public string typeSeminar_Title { get; set; }
    }
}
