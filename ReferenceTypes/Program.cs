using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int, decimal, float, enum, boolean -----> value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı 1 : " +sayi1);
            ////sayi1 = ?


            ////arrays, class, interface... -----> reference types
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0] = "+ sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Kemal";

            person2 = person1;
            person1.FirstName = "Barış";

            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Lefter";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Özil";

            Person person3 = customer;
            customer.FirstName = "Can";

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);               //Burası çok önemli. 'Boxing' yapıyoruz !!!

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }





        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        //base class : Person  (Bu sayede 44 ve 45.satırdaki işlemi yapabiliyoruz.)
        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }


        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }



        class PersonManager                             //temel class yapmak istiyorsak.
        {
            public void Add(Person person)              //Böyle yaptığımızda, buraya hem person'ı hem customer'ı hem de employee'ı gönderebiliriz.
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }


}
