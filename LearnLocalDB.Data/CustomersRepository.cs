using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLocalDB.Data
{
    public class CustomersRepository
    {
        public static List<DTO.Customer> GetCustomers()
        {
            ACMEEntities db = new ACMEEntities();
            var dbCustomers = db.Customers.ToList();

            var dtoCustomers = new List<DTO.Customer>();

            foreach (var dbCustomer in dbCustomers)
            {
                var dtoCustomer = new DTO.Customer()
                {
                    CustomerId = dbCustomer.CustomerId,
                    Name = dbCustomer.Name,
                    Address = dbCustomer.Address,
                    City = dbCustomer.City,
                    State = dbCustomer.State,
                    Postal_Code = dbCustomer.Postal_Code,
                    Notes = dbCustomer.Notes
                };

                dtoCustomers.Add(dtoCustomer);
            }

            return dtoCustomers;
        }
        
    }
}
