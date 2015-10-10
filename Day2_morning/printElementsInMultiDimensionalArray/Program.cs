using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printElementsInMultiDimensionalArray
{

    /*
    * Write a re-usable function that can iterate and output all elements of a Multidimensional Primitive Type Array.
    * The function should be able to take an Array of any dimension as a parameter.             
    */
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int[] nDimArray = new int[4]{2, 2, 2, 2};
            Array fourDimsArray = Array.CreateInstance(typeof(int), nDimArray);
            for (int i = 0; i < fourDimsArray.GetLength(0); i++)
            {
                for (int j = 0; j < fourDimsArray.GetLength(1); j++)
                {
                    for (int k = 0; k < fourDimsArray.GetLength(2); k++)
                    {
                        for (int l = 0; l < fourDimsArray.GetLength(3); l++)
                        {
                            int[] myIndicesArray = new int[4] { i, j, k, l };
                            fourDimsArray.SetValue(count++, myIndicesArray);
                        }

                    }

                }
            }
            // Displays the values of the Array.
            PrintAllValues(fourDimsArray);
            Console.ReadKey();
        }
        public static void PrintAllValues(Array myArr)
        {
            System.Collections.IEnumerator myEnumerator = myArr.GetEnumerator();
            int i = 0;
            int cols = myArr.GetLength(myArr.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", myEnumerator.Current);
            }
            Console.WriteLine();
        }
    }
}
