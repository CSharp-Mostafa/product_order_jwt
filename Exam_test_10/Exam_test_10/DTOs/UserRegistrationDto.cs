using System.ComponentModel.DataAnnotations;

namespace Exam_test_10.DTOs
{
    public class UserRegistrationDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
