using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Models
{
    public class Shipper : BaseHome
    {
        [Required]
        public string Name { get; set; }
        public string Province { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string MailAddress { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
