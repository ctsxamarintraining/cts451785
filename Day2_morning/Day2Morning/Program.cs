using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Morning
{
    /*
     * Declare and initialize 4D string array with dimensions  2 X 2 X 2 X 2. Iterate and print each element
     * of the above Array.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            string[,,,] fourDimstringArray = new string[2,2,2,2];
            for (int i = 0; i < fourDimstringArray.GetLength(0); i++)
            {
                for (int j = 0; j < fourDimstringArray.GetLength(1); j++)
                {
                    for (int k = 0; k < fourDimstringArray.GetLength(2); k++)
                    {
                        for (int l = 0; l < fourDimstringArray.GetLength(3); l++)
                        {
                            fourDimstringArray[i, j, k, l] = "TestString:" + count++;
                        }

                    }

                }
            }
            //printing
            for (int i = 0; i < fourDimstringArray.GetLength(0); i++)
            {
                for (int j = 0; j < fourDimstringArray.GetLength(1); j++)
                {
                    for (int k = 0; k < fourDimstringArray.GetLength(2); k++)
                    {
                        for (int l = 0; l < fourDimstringArray.GetLength(3); l++)
                        {
                            Console.WriteLine(fourDimstringArray[i, j, k, l]);
                        }

                    }

                }
            }           
            Console.ReadKey();
        }
    }
}
