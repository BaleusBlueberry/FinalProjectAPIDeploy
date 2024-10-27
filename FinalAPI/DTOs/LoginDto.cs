using System.ComponentModel.DataAnnotations;

namespace FinalAPI.DTOs
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(2), MaxLength(20)]
        public string Password { get; set; }
    }
}
