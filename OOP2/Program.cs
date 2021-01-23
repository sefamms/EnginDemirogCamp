using System;

namespace OOP2
{
   public class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer = new IndividualCustomer();
            customer.Id = 1;
            customer.CustomerNo = "12121";
            customer.CustomerName = "engin";
            customer.CustomerSurname = "Demirog";
            customer.TcNo = "12121212";
            
            CorporateCustomer customer1 = new CorporateCustomer();
            customer1.Id = 2;
            customer1.CustomerNo = "2323323";
            customer1.CompanyName = "kodlama.io";
            customer1.TaxNo = "12121";


            Customer customer2 = new IndividualCustomer();
            Customer customer3 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer1);

        }



    }
}
