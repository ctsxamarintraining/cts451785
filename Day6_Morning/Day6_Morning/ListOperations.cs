using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Morning
{
    class ListOperations
    {
        public static void operations()
        {
            Mylist list = new Mylist();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            list.print();
            list.Remove("two");
            Console.WriteLine("After remove");
            list.print();
        }
    }
    class Mylist : IList
    {
        private object[] data = new object[10];
        int count;
        public Mylist()
        {
            count = 0;
        }
        public int Add(object val)
        {
            if (count < data.Length)
            {
                data[count++] = val;
                return count - 1;
            }
            else
            {
                return -1;
            }
        }
        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }

        // IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            // Refer to the IEnumerator documentation for an example of
            // implementing an enumerator.
            throw new Exception("The method or operation is not implemented.");
        }


        public void Clear()
        {
            count = 0;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object value)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (data[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;

        }

        public void Remove(object value)
        {
            int index = IndexOf(value);
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
            }
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    }
}
