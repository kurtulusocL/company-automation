using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Models
{
    public class Role : BaseHome
    {
        public string RolName { get; set; }

        public ICollection<SetPassword> SetPasswords { get; set; }
    }
}
