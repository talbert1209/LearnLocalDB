using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using learnLocalDB.Persistence;


namespace LearnLocalDB.Persistence
{
    public class CustomersRepository
    {
        public static List<Customer> GetCustomers()
        {
            ACMEEntities db = new ACMEEntities();
            var dbCustomers = db.Customers.ToList();

            return dbCustomers;
        }
    }
}
