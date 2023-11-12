using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;
using static ServiceReference1.KPSPublicSoapClient;

namespace InterfaceAbstractDemo.Adapters
{
    public  class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new  MernisServiceReference.KPSPublicSoapClient();
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalID), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthDate.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
