using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1, FirstName="Ezgi", LastName="Ersan", City="İzmir"};

            Customer customer2 = new Customer(2, "Ayşe", "Demiroğ", "Ankara");

        }

        static void Method(int id, string firstName,string lastName, string city) 
        {

        }

    }

    class Customer
    {
        public Customer()
        {
            
        }
        //default constructor
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
