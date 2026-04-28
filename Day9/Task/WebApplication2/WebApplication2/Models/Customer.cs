
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public enum Gender { Male,Female }
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string PhoneNum { get; set; }
        public virtual IEnumerable<Product>? Products { get; set; }
    }
}
