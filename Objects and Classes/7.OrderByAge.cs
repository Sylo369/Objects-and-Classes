using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Classes
{
    public class OrderByAge
    {
        static void Main() 
        {
            List<string> command = new List<string>();
            List<Person> person = new List<Person>();

            do
            {
                command = Console.ReadLine()
                    .Split(" ")
                    .ToList();
                if (command[0] == "End")
                {
                    break;
                }
                person.Add(new Person(command[0], command[1], int.Parse(command[2])));
            }
            while (command[0] != "End");

            person = person.OrderBy(a => a.Age).ToList();

            foreach (var item in person)
            {
                Console.WriteLine(item);
            }
        }

        public class Person 
        {

            public Person(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }
            public string Name { get; set; }

            public int Age { get; set; }
            public string ID { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
    }
}
