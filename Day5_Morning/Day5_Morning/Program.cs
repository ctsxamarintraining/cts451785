using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Morning
{
    class Program
    {
        delegate void TestDelegate(int n);

        static void Main(string[] args)
        {
            Console.WriteLine("\n-------Question 1----\n");
            string str = "This is a test string";
            Console.WriteLine("No of Words:"+str.numOfWordsInString());
            Console.WriteLine("No of Characters:" + str.numOfCharsInString());

            Console.WriteLine("\n-------Question 2----\n");
            Nullable<int> nulType = null;
            Console.WriteLine("Value:"+nulType.HasValue);
            nulType = 20;
            Console.WriteLine("Value:" + nulType.Value);

            Console.WriteLine("\n-------Question 3----\n");
            //create delegate instances using anonymous method
            TestDelegate tDelegate = delegate(int i)
            {
                Console.WriteLine("Anonymous Method:"+i);
            };
            //call the delegate using the anonymous method 
            tDelegate(20);

            Console.WriteLine("\n-------Question 4----\n");
            var myType = new { Name = "Tester", id = 89, city = "Kochi" };
            Console.WriteLine("Name: {0}, id: {1}, city :{2}", myType.Name, myType.id,myType.city);

            Console.WriteLine("\n-------Question 5----\n");
            Partial par = new Partial();
            par.method11();
            par.method12();
            par.method21();
            par.method22();

        }   
    }
}
