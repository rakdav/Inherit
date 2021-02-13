using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.Age = age;
        }

        public int Age 
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
}
