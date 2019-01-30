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
            var dbCustomers = db.Customers.OrderBy(p => p.Name).ToList();

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

        public static void AddCustomer(DTO.Customer newCustomer)
        {
            ACMEEntities db = new ACMEEntities();
            var customers = db.Customers;

            var customer = new Customer()
            {
                CustomerId = newCustomer.CustomerId,
                Name = newCustomer.Name,
                Address = newCustomer.Address,
                City = newCustomer.City,
                State = newCustomer.State,
                Postal_Code = newCustomer.Postal_Code,
                Notes = newCustomer.Notes
            };

            customers.Add(customer);
            db.SaveChanges();
        }
    }
}
