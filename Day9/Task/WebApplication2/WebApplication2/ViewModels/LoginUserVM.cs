using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels
{
    public class LoginUserVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "User Name is required for login!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required for login!"),DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
