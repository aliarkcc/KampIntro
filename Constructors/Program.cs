using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, CustomerName = "Mehmet Ali", CustomerSurname = "Arkac", City = "Aksaray" };

            Customer customer1 = new Customer() { Id = 2, CustomerName = "Salih", CustomerSurname = "Conta", City = "Amerika" };

            Customer customer2 = new Customer(2, "Caner", "Selda", "Muş");

            Console.WriteLine(customer2.CustomerName);

        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string name,string surname,string city)
        {
            Id = id;
            CustomerName = name;
            CustomerSurname = surname;
            City = city;
        }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string City { get; set; }
    }
}
