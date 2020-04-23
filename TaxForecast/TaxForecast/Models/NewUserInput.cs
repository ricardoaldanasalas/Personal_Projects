using System.ComponentModel.DataAnnotations;

namespace TaxForecast.Models
{
    public class NewUserInput
    {
        [Required(ErrorMessage ="Please enter your First Name")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Please enter your Middle Name")]
        public string Mname { get; set; }
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Please enter your Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify your Marriage Status")]
        public string? MarriageStatus { get; set; }

    }
}
