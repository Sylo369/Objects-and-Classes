using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Program
    {
        static void test()
        {
            int numStudents = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < numStudents; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ")
                    .ToList();

                students.Add(new Students(input[0], input[1], double.Parse(input[2])));
            }

            students = students.OrderByDescending(a => a.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }


        }

        public class Students 
        {
            public Students(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public string FirstName{ get; set; }
            public string LastName{ get; set; }
            public double Grade{ get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:F2}"; // Customize the format as needed
            }

        }
    }
}
