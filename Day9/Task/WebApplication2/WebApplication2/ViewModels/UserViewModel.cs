using System.ComponentModel.DataAnnotations;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get;set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType(DataType.Password),Compare("Password",ErrorMessage ="Passwords does not match!")]
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public Education EducationLevel { get; set; }

    }
}
