using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Models
{
    public class ProductControl : BaseHome
    {
        public string Place { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
