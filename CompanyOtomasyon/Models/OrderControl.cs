using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Models
{
    public class OrderControl : BaseHome
    {
        public string Place { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
