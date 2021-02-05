using System;

namespace Constructor
{
   public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, FirstName = "sefa", LastName = "memis",City="ankara" };

            customer.City = "izmir";


            Customer customer1 = new Customer(2,"demir","demiroğ","ankara");

            Console.WriteLine(customer1.FirstName);  
           
        }
    }
    public class Customer
    {

        public Customer()
        {

        }

        public Customer(int id,string firtaname,string lastname,string city)
        {
            this.Id = id;
            this.FirstName = firtaname;
            this.LastName = lastname;
            this.City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  City { get; set; }

    }
}
