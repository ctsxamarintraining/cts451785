using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Afternoon
{
    class FileExceptions
    {
        public static void readFile(string path)
        {
            try
            {
                // Open the file to read from.
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (FileNotFoundException notFoundEx)
            {
                Console.WriteLine("File not found");
            }
            catch (FileLoadException floadEx)
            {
                Console.WriteLine("File cannot be loaded.");
            }
            catch (PathTooLongException pathLongEx)
            {
                Console.WriteLine("Path or file name is longer than the system-defined maximum length.");
            }
            catch (EndOfStreamException endEx)
            {
                Console.WriteLine("Reading is attempted past the end of a stream.");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
