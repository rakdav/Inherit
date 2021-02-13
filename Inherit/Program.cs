using System;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Tom");
            tom.Display();
            Employee jerry = new Employee("Jerry",21,"Sony");
            jerry.Display();
            Employee employee = new Employee("Bill", 27, "Microscoft");
            Person person = employee;
            Console.WriteLine(person.Name+" "+person.Age);
            person.Age = 56;
            Console.WriteLine(employee.Age+" "+person.Age);
            object p1 = new Employee("Tim", 24, "Samsung");
            object p2 = new Client("Goge", "MTS");
            object p3 = new Person("Sam", 45);
            Employee employee2 = (Employee)person;
            ((Person)p1).Display();
            if(p2 is Client)
            {
                Client client = p2 as Client;
                client.Display();
            }

            CheckYear checkYear = new CheckYear(45.7m,6,2019);
            Console.WriteLine(checkYear.Total());
            Console.WriteLine(checkYear.Age());
        }
    }
}
