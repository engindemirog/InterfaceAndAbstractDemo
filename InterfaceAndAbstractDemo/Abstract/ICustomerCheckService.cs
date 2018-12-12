using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
