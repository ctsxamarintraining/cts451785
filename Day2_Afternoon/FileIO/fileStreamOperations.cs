using System;
using System.IO;

namespace FileIO
{
	public class fileStreamOperations
	{
		/*
		 * 3. Create a file with text content (say more than 1Mb). Write a function which copies the contents of the file 
		 * using Stream Reader/Writer with a help of byte array into another source destination. note: the byte array's maximum 
		 * size should be declared as 500 bytes.
		 */ 
		public fileStreamOperations ()
		{
			
		}
        public static void readAndWrite()
        {
            string pathSource = @"C:\Users\451785\Documents\Visual Studio 2012\Projects\FileIO\1MB.txt";
            string outputPath = @"C:\Users\451785\Documents\Visual Studio 2012\Projects\FileIO\newfile.txt";
			byte[] contents = fileStreamOperations.readFile (pathSource);
			fileStreamOperations.writeFile (contents, outputPath);
            Console.WriteLine("Successfully written!!");
        }
		static byte[] readFile(string inputPath)
		{
			using (FileStream fsSource = new FileStream (inputPath,
				                             FileMode.Open, FileAccess.Read)) {
				byte[] bytes = new byte[fsSource.Length];
				int numBytesRemaining = (int)fsSource.Length;
				int numBytesRead = 0;
				while (numBytesRemaining > 0)
				{
					int n = fsSource.Read(bytes, numBytesRead, numBytesRemaining);

					// Break when the end of the file is reached.
					if (n == 0)
						break;
					numBytesRead += n;
					numBytesRemaining -= n;
				}
				return bytes;
			}
		}
		static void writeFile(byte[] bytes,string outputPath)
		{
			using (FileStream fsNew = new FileStream(outputPath,
				FileMode.Create, FileAccess.Write))
			{
				fsNew.Write(bytes, 0, bytes.Length);
			}
		}

	}
}

