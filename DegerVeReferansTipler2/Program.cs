using System;

namespace DegerVeReferansTipler2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, boolean, float, enum value types
            int number1 = 10;
            int number2 = 20;

            number1 = number2;
            number2 = 100;

            Console.WriteLine("Number 1:" + number1);

            //array, class, interface... reference types

            int[] numbers1 = new int[] {1, 2, 3};
            int[] numbers2 = new int[] {10, 20, 30};

            numbers1 = numbers2;
            numbers2[0] = 1000;

            Console.WriteLine("Numbers1[0]:" + numbers1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Anıl";

            person2 = person1;
            person1.FirstName = "Mehmet";

            Console.WriteLine(person2.FirstName);





            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            //Inheritance yaptığımız class türünde bir şeye inheritance'ı alan classı atayabiliriz.
            Person person3 = customer; //Bu projede Person classı base classtır.
            //Yukarıda her ne kadar person 3 ile customer'ı  eşitlemiş olsak da person3. dediğimizde CreditCardNumberı göremeyiz.
            //CreditCardNumber'ı görmek istiyorsak "Boxing" İşlemi yapmalıyız.
            //customer ve employee'i person cinsinden neden yazıyoruz? Çünkü tek bir operasyon classı ile person, customer ve employee'i
            //çalıştırmak istiyoruz.Bkz. 60,61,62,85,86,87,88

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);//Boxing. 

            

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employee);
            Console.ReadLine();
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
