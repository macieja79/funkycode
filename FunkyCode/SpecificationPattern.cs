using System;
using System.Collections.Generic;
using System.Text;

namespace FunkyCode
{
    public class SpecificationPattern
    {

       

        void ProceedCustomer(Customer customer)
        {
            if (customer.Accounts.Count > 10)
            {
                // do some action
            }
        }


    }
}
