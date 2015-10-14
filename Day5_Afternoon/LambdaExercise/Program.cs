using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[] {
                    new Person{ Age = 10, Name = "Abigail", Degree = AcademicDegree.None},
                    new Person{ Age = 71, Name = "Manohar", Degree = AcademicDegree.Doctorate },
                    new Person{ Age = 22, Name = "Manmohan", Degree = AcademicDegree.UG },
                    new Person{ Age = 14, Name = "Mohammed", Degree = AcademicDegree.Tenth },
                    new Person{ Age = 12, Name = "John", Degree = AcademicDegree.None },
                    new Person{ Age = 11, Name = "Gita", Degree = AcademicDegree.None },
                    new Person{ Age = 44, Name = "Ram", Degree = AcademicDegree.PG },
                    new Person{ Age = 55, Name = "Gopi", Degree = AcademicDegree.UG },
                    new Person{ Age = 33, Name = "Ismail", Degree = AcademicDegree.Intermediate },
                    new Person{ Age = 101, Name = "Kiriti", Degree = AcademicDegree.PG },
                    new Person{ Age = 23, Name = "Joseph", Degree = AcademicDegree.Doctorate },
                    new Person{ Age = 89, Name = "Sukhwinder", Degree = AcademicDegree.UG },
                    new Person{ Age = 89, Name = "Raghu", Degree = AcademicDegree.None }
            
            };


            Console.WriteLine("peopleWithUGDegree");
            Person[] peopleWithUGDegree = Array.FindAll(people, person => person.Degree.Equals(AcademicDegree.UG));
            foreach(var person in peopleWithUGDegree)
                Console.WriteLine(person.Name);

            Console.WriteLine("\npeopleWithNoDegree");
            Person[] peopleWithNoDegree = Array.FindAll(people, person => person.Degree.Equals(AcademicDegree.None));
            foreach (var person in peopleWithNoDegree)
                Console.WriteLine(person.Name);

            Console.WriteLine("\npeopleOlderThan70");
            Person[] peopleOlderThan70 = Array.FindAll(people, person => person.Age > 70);
            foreach (var person in peopleOlderThan70)
                Console.WriteLine(person.Name);

            Console.WriteLine("\npeopleOlderThan70WithDegree");
            Person[] peopleOlderThan70WithDegree = Array.FindAll(people, person => (person.Age > 70) && !(person.Degree.Equals(AcademicDegree.None)));
            foreach (var person in peopleOlderThan70WithDegree)
                Console.WriteLine(person.Name);

            Console.WriteLine("\npeopleOlderThan70WithoutDegree");
            Person[] peopleOlderThan70WithoutDegree = Array.FindAll(people, person => (person.Age > 70) && (person.Degree.Equals(AcademicDegree.None)));
            foreach (var person in peopleOlderThan70WithoutDegree)
                Console.WriteLine(person.Name);

            Console.WriteLine("\navgAgeOfPeopleWithDoctorateDegree");
            double avgAgeOfPeopleWithDoctorateDegree = people.Where(person=>person.Degree.Equals(AcademicDegree.Doctorate)).Average(person => person.Age);
            Console.WriteLine("Average:"+avgAgeOfPeopleWithDoctorateDegree);

            Console.WriteLine("\npeopleBetween30And60WithUGDegree");
            Person[] peopleBetween30And60WithUGDegree = Array.FindAll(people, person => (person.Age >= 30) && (person.Age <= 60)&&(person.Degree.Equals(AcademicDegree.UG)));
            foreach (var person in peopleBetween30And60WithUGDegree)
                Console.WriteLine(person.Name);
        }

    }


    public class Person {
        public string Name { get; set; }
        public int Age { get; set; }
        public AcademicDegree Degree { get; set; }
    }

    public enum AcademicDegree{
        
        None,

        Tenth, 

        Intermediate,

        UG,        
    
        PG,

        Doctorate
    }
}
