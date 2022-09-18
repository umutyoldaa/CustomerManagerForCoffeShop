using CustomerManagerForCoffeShop.Abstract;
using CustomerManagerForCoffeShop.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerManagerForCoffeShop.Adapter
{
    internal class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
           

            return true;
        }
    }
}
