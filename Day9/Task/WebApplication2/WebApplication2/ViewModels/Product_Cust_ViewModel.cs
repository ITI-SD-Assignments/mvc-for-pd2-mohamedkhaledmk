using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class Product_Cust_ViewModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
    }
}
