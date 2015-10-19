using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day6
{
    class Comparers
    {
        public static void execute()
        {
            //IEqualityComparer
            var actors = Actor.CreateSome();
            actors.Add(new Actor() { FirstName = "George", LastName = "Clooney" });
            var distinct = actors.Distinct(new ActorComparer());
            foreach(var actr in distinct)
                Console.WriteLine(actr);


            //Icomparer
            IComparer<Actor> firstNameComparer = new firstNameComparer();
            IComparer<Actor> lastNameComparer = new lastNameComparer();
            var actorArray = actors.ToArray();
            Array.Sort(actorArray, firstNameComparer);
            Console.WriteLine("\n\nSorted by firstname");
            foreach (var actr in actorArray)
                Console.WriteLine(actr);

            Array.Sort(actorArray, lastNameComparer);
            Console.WriteLine("\nSorted by lastname");
            foreach (var actr in actorArray)
                Console.WriteLine(actr);
        }
        class ActorComparer : IEqualityComparer<Actor>
        {

            public bool Equals(Actor x, Actor y)
            {
                return x.FirstName == y.FirstName && x.LastName == y.LastName;
            }

            public int GetHashCode(Actor obj)
            {
                return (obj.FirstName+obj.LastName).GetHashCode();
            }
        }


        //Icomparer
        //to sort by firstName
        public class firstNameComparer : IComparer<Actor>
        {
            public int Compare(Actor x, Actor y)
            {
                return string.Compare(x.FirstName, y.FirstName);
            }
        }


        //to sort by firstName
        public class lastNameComparer : IComparer<Actor>
        {
            public int Compare(Actor x, Actor y)
            {
                return string.Compare(x.LastName, y.LastName);
            }
        }
    }
}
