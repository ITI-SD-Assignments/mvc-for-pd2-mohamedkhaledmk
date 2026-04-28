using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [ForeignKey("Customer")]
        public int CustID { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
