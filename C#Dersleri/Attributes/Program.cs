using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Age = 25
            };
            CustomerDal customerDal = new CustomerDal();
            customerDal.AddNew(customer);
            Console.ReadLine();
        }
        [ToTable("Customers")]
        class Customer
        {
            [RequiredProperty]
            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }
        }
        class CustomerDal
        {
            [Obsolete("Don't Use Add, İnstead Use AddNew Method")]
            public void Add(Customer customer) 
            {
                Console.WriteLine("{0} , {1} , {2} , {3} Added" , customer.Id , customer.FirstName , customer.LastName , customer.Age);
            }
            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0} , {1} , {2} , {3} Added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }
        [AttributeUsage(AttributeTargets.Property , AllowMultiple = true)]
        class RequiredPropertyAttribute : Attribute
        {

        }
        [AttributeUsage(AttributeTargets.Class)]
        class ToTableAttribute : Attribute
        {
            private string _tableName;
            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }
    }
}
