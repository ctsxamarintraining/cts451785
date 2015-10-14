using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class CopyFolderContents
    {
        /*
         * 2. Create a folder with few nested files and sub-folders (not less than 3 levels). 
         * Write a recursive function to copy the source folder to a destination folder along with all the contents in it.
         */
        public static void copyFolder()
        {
            string src = @"C:\Users\451785\Documents\Visual Studio 2012\Projects\FileIO\Source";
            string dest = @"C:\Users\451785\Documents\Visual Studio 2012\Projects\FileIO\Destination";
            if (copyFolderContent(src, dest))
            {
                Console.WriteLine("Contents copied successfully");
            }
            else
            {
                Console.WriteLine("unable to copy!!!");
            }
        }
        static bool copyFolderContent(string SourcePath, string DestinationPath)
        {
            SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
            DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

            try
            {
                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                    {
                        Directory.CreateDirectory(DestinationPath);
                    }

                    foreach (string files in Directory.GetFiles(SourcePath))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        fileInfo.CopyTo(string.Format(@"{0}\{1}", DestinationPath, fileInfo.Name), true);
                    }

                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(drs);
                        if (copyFolderContent(drs, DestinationPath + directoryInfo.Name) == false)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
