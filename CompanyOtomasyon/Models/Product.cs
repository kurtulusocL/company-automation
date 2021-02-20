using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Models
{
    public class Product : BaseHome
    {
        [Required]
        public string Name { get; set; }
        public int KDV { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsRepo { get; set; }

        public int CategoryId { get; set; }
        public int EmployeeId { get; set; }
        public int ProductControlId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ProductControl ProductControl { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}

