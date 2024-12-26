using System.ComponentModel.DataAnnotations;

namespace Core_Blog.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Enter the username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Enter the Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Again enter the Password")]
        [Compare("Password",ErrorMessage = "Passwords are no match")]
        public string ConfimPassword { get; set; }
        [Required(ErrorMessage = "Enter the E-Mail")]
        public string Mail { get; set; }
    }
}
