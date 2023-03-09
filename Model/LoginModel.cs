using System.ComponentModel.DataAnnotations;

namespace MagicLink.Model
{
    public class LoginModel
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
