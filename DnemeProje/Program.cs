using System;

namespace DnemeProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Caner";

            Person person2 = new Person();
            person2 = person1;

            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "13245678";

            Employee employee = new Employee();
            employee.FirstName = "Saadet";

            Person person3 = customer;
            person3.FirstName = "bak";
            Console.WriteLine(person3.FirstName);

            Console.WriteLine(((Customer)person3).CreditCardNumber);


            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
