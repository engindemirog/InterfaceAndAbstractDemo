using System;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using InterfaceAndAbstractDemo.MernisServiceReference;

namespace InterfaceAndAbstractDemo.Adapters
{
    public class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client =new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
