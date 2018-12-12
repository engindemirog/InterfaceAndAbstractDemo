using System;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
           Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
