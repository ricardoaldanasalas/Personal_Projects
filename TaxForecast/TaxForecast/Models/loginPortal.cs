using System.ComponentModel.DataAnnotations;

namespace TaxForecast.Models
{
    public class loginPortal
    {
        [Required(ErrorMessage = "Please enter your email as a UserName")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string Password { get; set; }

    }
}
