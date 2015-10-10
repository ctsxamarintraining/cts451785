using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortPersonByAge
{
    /*3
     * Create a custom type Person with FirstName, LastName and Age properties.
     * Write a re-usable function that can Sort this Person[] Array by age.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Person[] personList = new Person[] 
            { 
                new Person { firstName = "Alex", lastName = "Huem", age = 34 },
                new Person { firstName = "Bary", lastName = "Bart", age = 22 },
                new Person { firstName = "Carty", lastName = "Cooler", age = 57 },
                new Person { firstName = "Declase", lastName = "Deen", age = 88 }
            };
            Array.Sort(personList);
            foreach (Person p in personList)
                Console.WriteLine(p.firstName + "   " + p.age);
            Console.ReadKey();
        }
    }
}
