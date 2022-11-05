
using System.Collections.Generic;


namespace SalesWebMvc.Models.ViewsModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; } 
    }
}
