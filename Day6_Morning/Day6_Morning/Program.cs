using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample sam = new sample();
            //sam.Execute();
            ListOperations.operations();
            Console.ReadKey();
        }
        public class sample
        {
            public void Execute()
            {
                myEnumerable myObj = new myEnumerable();
                var enumerator = myObj.GetEnumerator();
                    while(enumerator.MoveNext())
                        Console.WriteLine(enumerator.Current);
            }
        }
        public class MyEnumerator : IEnumerator
        {
            int[] data = new int[] { 1, 2, 3, 4, 5,6 };
            int currentIndex = -1;

            public object Current
            {
                get {
                       return data[currentIndex];
                }
                
            }

            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex < data.Length-1)
                {
                    while (data[currentIndex] % 2 != 0 && currentIndex < data.Length)
                    {
                        currentIndex++;
                    }
                    if (currentIndex > data.Length)
                        return false;
                    else
                        return true;
                }
                else
                    return false;

            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
        public class myEnumerable : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                return new MyEnumerator();
            }
        }
    }
}
