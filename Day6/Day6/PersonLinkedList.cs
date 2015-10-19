using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Day6
{
    class PersonLinkedList
    {
        LinkedList<Person> personList = new LinkedList<Person>();
        public void execute()
        {
            PopulateList(10);
            People peopleList = new People(personList);
            var enumerator = peopleList.GetEnumerator();
            Console.WriteLine("NAME\tID\tLOCATION\n");
            while (enumerator.MoveNext())
            {
                Person per = (Person)enumerator.Current;
                Console.WriteLine(String.Format("{0}\t{1}\t{2}", per.name,per.id,per.location));
            }
        }

        void PopulateList(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                personList.AddLast(new Person { name="Person "+i,id=i,location="location "+i});
            }
        }
        // implements IEnumerable 
        class People:IEnumerable
        {
            private LinkedList<Person> people;

            public People(LinkedList<Person> list)
            {
                people = list;
            }

            public IEnumerator GetEnumerator()
            {
                return new PeopleEnumerator(people);
            }
        }
        //implement IEnumerator.
        class PeopleEnumerator : IEnumerator
        {
            private LinkedList<Person> people;
            int position = -1;

            public PeopleEnumerator(LinkedList<Person> list)
            {
                people = list;
            }

            public object Current
            {
                get { return people.ElementAt(position); }
            }

            public bool MoveNext()
            {
                position++;
                if (position > people.Count()-1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}
