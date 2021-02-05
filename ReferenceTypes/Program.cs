using System;

namespace ReferenceTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;

            int[] sayilar = new int[] { 1, 2, 3 };

            int[] sayilar1 = new int[] { 10, 20, 30 };

            sayilar = sayilar1;

            sayilar1[0] = 1000;

           // Console.WriteLine("sayi1" + sayilar[0]);



            Person person = new Person();       
            Customer customer = new Customer();
            customer.CreditCardNumber = 12121;
            Employee employee = new Employee();


            Person person1 = customer;
            customer.FirstName = "ahmet";

            // Console.WriteLine(((Customer)person1).CreditCardNumber));

            PersonManager manager = new PersonManager();

            manager.Add(employee);

        }

    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Customer:Person
    {
        public int CreditCardNumber { get; set; }

    }
    public class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    public class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
