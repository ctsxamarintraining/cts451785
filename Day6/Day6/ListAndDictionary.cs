using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day6
{
    class ListAndDictionary
    {
        public static void execute()
        {
            /* List  */

            List<int> list = new List<int>();
            list.Add(45);
            list.AddRange(new List<int>() { 56, 67});
            printlist(list);
            Console.WriteLine("Remove:56");
            list.Remove(56);
            printlist(list);
            Console.WriteLine("insert 33 at 0");
            list.Insert(0, 33);
            printlist(list);
            Console.WriteLine("clear list");
            list.Clear();

            Console.WriteLine("\nDictionary");

            /* Dictionary  */

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            printDic(dict);
            Console.WriteLine("conatins one ?" + dict.ContainsValue("one"));
            Console.WriteLine("remove 1");
            dict.Remove(1);
            Console.WriteLine("add 4");
            dict.Add(4, "four");
            printDic(dict);

            dict.Clear();


        }
        static void printlist(List<int> list)
        {
            Console.WriteLine("---------List now------------");
            foreach(int i in list)
                Console.WriteLine(i);
            Console.WriteLine("-----------------------------------");
        }
        static void printDic(Dictionary<int, string> d)
        {
            Console.WriteLine("---------Dictionary now------------");
            foreach(string s in d.Values)
                Console.WriteLine(s);
            Console.WriteLine("-----------------------------------");
        }
    }
}
