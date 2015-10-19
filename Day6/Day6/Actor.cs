using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day6
{
    class Actor
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public override string ToString()
        {
            return FirstName + "  " + LastName;
        }

        public static List<Actor> CreateSome()
        {
            return new List<Actor>()
            {
                new Actor() { 
                 FirstName = "Brad", 
                 LastName = "Pitt"},
                new Actor() { 
                 FirstName = "Andy", 
                 LastName = "Garcia"},
                new Actor() { 
                 FirstName = "George", 
                 LastName = "Clooney"},
                new Actor() { 
                 FirstName = "Jullia", 
                 LastName = "Roberts"}
            };
        }
    }
}
