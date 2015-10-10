using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortPersonByAnyAttribute
{
    /*
     * Write a common function that can Sort Person[] Array on the property of our choice
     * Hint: Use Array.Sort(arrObj, IComparer)
     */

    class Program
    {
        //to sort by firstName
        public class firstNameComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return string.Compare(x.firstName, y.firstName);
            }
        }


        //to sort by firstName
        public class lastNameComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return string.Compare(x.lastName, y.lastName);
            }
        }


        //to sort by firstName
        public class ageComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                if (x.age < y.age)
                    return 1;
                else if (x.age > y.age)
                    return -1;
                else
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            Person[] personList = new Person[] 
            { 
                new Person { firstName = "Declase", lastName = "Deen", age = 88 },
                new Person { firstName = "Alex", lastName = "Huem", age = 34 },                
                new Person { firstName = "Carty", lastName = "Cooler", age = 57 },                
                new Person { firstName = "Bary", lastName = "Bart", age = 22 }
            };

            IComparer<Person> firstNameComparer = new firstNameComparer();
            IComparer<Person> lastNameComparer = new lastNameComparer();
            IComparer<Person> ageComparer = new ageComparer();

            Array.Sort(personList,firstNameComparer);
            Console.WriteLine("\nSorted by firstname\n");
            foreach (Person p in personList)
                Console.WriteLine(p.firstName  +"  " + p.lastName);

            Array.Sort(personList, lastNameComparer);
            Console.WriteLine("\nSorted by lastname\n");
            foreach (Person p in personList)
                Console.WriteLine(p.firstName + "  " + p.lastName);

            Array.Sort(personList, ageComparer);
            Console.WriteLine("\nSorted by Age\n");
            foreach (Person p in personList)
                Console.WriteLine(p.firstName + "  " + p.lastName+"  "+p.age);
            Console.ReadKey();
        }
    }
}
