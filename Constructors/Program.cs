using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Anıl", LastName = "Bayır", City = "Bursa" };
            Customer customer2 = new Customer(2, "Mehmet", "Soysoy", "İstanbul");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            //customer1 ile customer3 işlev açısından birbirine eşittir.Sadece gösterim şekilleri farklıdır.
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }

        
    }

    class Customer
    {
        public Customer()
        {

        }
        //default constructor:Yazdıysak bizim yazdığımız yazmadıysak arka planda olan constructor çalışır.
        //Biz ayrıca constructor yazarsak default constructorı ezmiş oluruz.
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
