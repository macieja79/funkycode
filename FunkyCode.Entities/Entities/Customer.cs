using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyCode
{
    public class Customer : Entity
    {
        

        public string Name { get; set; }
        public string LastName { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
