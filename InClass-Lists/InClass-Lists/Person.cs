using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Lists
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            string info = "";

            info += $"\n------------------------------";
            info += $"\nName: {Name}";
            info += $"\nAge: {Age}";
            info += $"\n------------------------------";

            return info;
        }
    }
}
