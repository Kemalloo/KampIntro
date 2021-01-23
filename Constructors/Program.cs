using System;

namespace Constructors
{
    class Program                       //Constructor, bir class'ı new'ledğimiz zaman çalışan bloktur.
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1907, FirstName= "Alex", LastName= "De Souza", City= "Rio" };
                                                                                   //Birbirinden farklı iki kullanım söz konusu.
            Customer customer2 = new Customer(1910, "Kemal", "Bayram", "İzmir");


            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
            Console.WriteLine(customer2.City);

        }


    }


    class Customer
    {
        public Customer()                                                            //customer1'i çalıştırıyor.
        {

        }


        //default constructor
        public Customer(int id, string firstName, string lastName, string city)                   //Constructor'da aslında bir metottur.
        {
            Id = id;
            FirstName = firstName;                                                                  //customer2'yi çalıştırıyor.
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
