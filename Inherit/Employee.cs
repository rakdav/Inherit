using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Employee:Person
    {
        public string Company { get; set; }

        public Employee(string name,int age,string company):base(name,age)
        {
            Company = company;
        }

        public new void Display()
        {
            Console.WriteLine("Name:"+Name+" Company:"+Company);
        }
    }
}
