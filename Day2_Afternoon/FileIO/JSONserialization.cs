using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class JSONserialization
    {
        /*Create an object of any class and serialize it to a file using JSON serialization. 
         * (use Newtonsoft.json NuGet package if needed).
         */
        public static void write()
        {
            Person per = new Person { name = "Jiller", Id = 12 };
            using (StreamWriter file = File.CreateText(@"C:\Users\451785\Documents\Visual Studio 2012\Projects\FileIO\person.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, per);
            }
        }
    }
}
