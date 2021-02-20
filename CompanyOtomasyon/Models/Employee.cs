using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Models
{
    public class Employee : BaseHome
    {
        [Required]
        public string NameSurname { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string MailAddress { get; set; }
        [Required]
        public string Address { get; set; }
        public string Photo { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
