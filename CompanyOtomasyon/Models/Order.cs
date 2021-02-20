using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Models
{
    public class Order : BaseHome
    {
        [Required]
        public string OrderNumber { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime ArriveDate { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string Country { get; set; }
        public bool IsSent { get; set; }

        public int ShipperId { get; set; }
        public int? ProductId { get; set; }
        public int EmployeeId { get; set; }
        public int OrderControlId { get; set; }
        public int CustomerId { get; set; }

        public virtual Shipper Shipper { get; set; }
        public virtual Product Product { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual OrderControl OrderControl { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
