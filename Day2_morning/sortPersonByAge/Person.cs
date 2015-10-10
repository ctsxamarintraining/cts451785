using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortPersonByAge
{
    class Person :IComparable<Person>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        //descending order
        public int CompareTo(Person other)
        {
            if (this.age < other.age)
                return 1;
            else if (this.age > other.age)
                return -1;
            else
                return 0;
        }
    }
}
