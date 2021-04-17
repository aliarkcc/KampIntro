using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            projectManager.Update(new InternManager());
        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri Ekleme Kodları
            Console.WriteLine("Musteri Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Eklendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel Ekleme Kodları
            Console.WriteLine("Personel Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }

    class InternManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
