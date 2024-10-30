using Microsoft.AspNetCore.Mvc;

namespace Amusement_park
{
    public class CustomersService
    {
        static List<Customer> customers = new List<Customer>
    {
        new Customer
        {
            Id = "123456789",
            Name = "Yossi Choen",
            Email = "yosi@gmail.com",
            Phone = "050-1234567",
            Password = "password123",
            DateRegistration =DateTime.Now,
            Points = 100,
            CustomerType = "Regular"
        }
    };


        public List<Customer> Get()
        {
            return customers;
        }

        public Customer GetById(string id)
        {
            return customers.FirstOrDefault(x => x.Id == id);
        }

        public ActionResult<bool> Add(Customer customer)
        {
            customers.Add(customer);
            return true;
        }

        public ActionResult<bool> Update(Customer customer)
        {
           for (int i = 0;i<customers.Count;i++)
            {
                if (customers[i].Id==customer.Id)
                {
                    customers[i] = customer;
                    return true;
                }
            }
            return false;

        }

        public ActionResult<bool> Remove(string id)
        {
           return customers.Remove(customers.FirstOrDefault(x => x.Id == id));
        }
    }
}
