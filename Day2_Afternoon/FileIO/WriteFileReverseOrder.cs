using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class WriteFileReverseOrder
    {
        /*
			 * 1. Write a program that reads a file and writes out a new file with the lines in reversed order (i.e. the first line in the old file becomes the 
			 * last one in the new file.)
			*/
        public static void write()
        {

            string[] fileContents = System.IO.File.ReadAllLines(@"C:\Users\451785\Documents\Projects\FileIO\readfile.txt");
            Array.Reverse (fileContents);
            System.IO.File.WriteAllLines(@"C:\Users\451785\Documents\Projects\FileIO\ReverseWrite.txt", fileContents);
            
        }
    }
}
