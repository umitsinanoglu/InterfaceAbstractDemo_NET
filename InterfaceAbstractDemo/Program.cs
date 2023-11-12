using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System.Reflection.Metadata.Ecma335;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                BirthDate = new System.DateTime(1980, 03, 23),
                FirstName = "Hasan",
                LastName = "Sinanoğlu",
                id = 1,
                NationalID = "12345678901"
            });

        }
    }
}
