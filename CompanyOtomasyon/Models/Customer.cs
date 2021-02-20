using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Models
{
    public class Customer : BaseHome
    {
        [Required]
        public string NameSurname { get; set; }

        public string CompanyName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string MailAddress { get; set; }
        [Required]
        public string FaxNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
