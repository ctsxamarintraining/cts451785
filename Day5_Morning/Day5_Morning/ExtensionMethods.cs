using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Morning
{
    public static class ExtensionMethods
    {
        public static int numOfWordsInString(this string str)
        {
            return str.Split().Length;
        }
        public static int numOfCharsInString(this string str)
        {
            return str.ToCharArray().Count(c=>c!=' ');
        }
    }
}
