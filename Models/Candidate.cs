using System.ComponentModel.DataAnnotations;

namespace ngMVC1.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-mail is required!")]
        public string? Email { get; set; } = string.Empty;
       
        [Required(ErrorMessage = "First-Name is required!")]
        public string? FirstName { get; set; } = string.Empty;
       
        [Required(ErrorMessage = "Last-Name is required!")]
        public string? LastName { get; set; } = string.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }




    }
}
