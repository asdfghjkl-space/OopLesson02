using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];

            persons[0] = new Employee
            {
                Number = 352,
                FirstName = "涼太",
                LastName = "田中",
                Email = "rtanaka@example.com",
                HireDate = new DateTime(2015, 10, 1),
                Birthday = new DateTime(1995, 4, 15)
            };
            //employee.Print();

            persons[1] = new Customer
            {
                Id = "2001",
                FirstName = "涼太",
                LastName = "池田",
                CreditCardNumber = "115644587845",
                Rank = 3,
                Birthday = new DateTime(1994, 4, 15)
            };
            //customer.Print();

            persons[2] = new Customer
            {
                Id = "2001",
                FirstName = "太郎",
                LastName = "池田",
                CreditCardNumber = "1156554787845",
                Rank = 6
            };
            //customer2.Print();

            foreach (var item in persons)
            {
                //item.Print();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
