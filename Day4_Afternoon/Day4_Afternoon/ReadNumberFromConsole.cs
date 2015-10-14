using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Afternoon
{
    class ReadNumberFromConsole
    {
        public static void readInteger()
        {
             Console.Write("Enter a number:");
            try
            {
                int number = Convert.ToInt16(Console.ReadLine());
                if (number < 0)
                {
                    throw new NegativeNumberException("Invalid number");
                }
                else
                {
                    double sqrt = Math.Sqrt((double)number);
                    Console.WriteLine("Square root :" + sqrt);
                }
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("Invalid number");
            }
            catch (NegativeNumberException nEX)
            {
                Console.WriteLine("Invalid number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
