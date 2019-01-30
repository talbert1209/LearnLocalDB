using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnLocalDB;

namespace LearnLocalDB.Domain
{
    public class CustomersManager
    {
        public static List<DTO.Customer> GetCustomers()
        {
            var customers = Data.CustomersRepository.GetCustomers();
            return customers;
        }

        public static void AddCustomer(DTO.Customer newCustomer)
        {
            Data.CustomersRepository.AddCustomer(newCustomer);
        }
    }
}
