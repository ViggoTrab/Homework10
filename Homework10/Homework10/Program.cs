using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var names = new List<string> { "Alice", "Bob", "Charlie", "Diana", "Edward", "Fiona", "George", "Hannah", "Ian", "Julia" };
            var students = new List<Student>();

            for (int i = 0; i < 100; i++)
            {
                var student = new Student(
                    name: names[random.Next(names.Count)] + i,
                    age: random.Next(18, 25),
                    grades: new List<int>
                    {
                random.Next(20, 100),
                random.Next(50, 100),
                random.Next(70, 100)
                    }
                );

                students.Add(student);
            }

            //a
            var studentNames = students.Select(student => student.Name).ToList();

            Console.WriteLine("List of the students names:");
            foreach (var studentName in studentNames)
            {
                Console.WriteLine(studentName);
            }

            //b
            var studentsWithGradeOver90 = students.Where(student => student.Grades.Any(grade => grade > 90)).ToList();

            Console.WriteLine("Students with at least one grade over 90:");
            foreach (var student in studentsWithGradeOver90)
            {
                Console.WriteLine(student.Name);
            }

            //c
            var anyStudentWithAllGradesOver80 = students.Any(student => student.Grades.All(grade => grade > 80));

            Console.WriteLine("Is there any student with all grades over 80?");
            Console.WriteLine(anyStudentWithAllGradesOver80 ? "Yes" : "No");

            //d
            var allGrades = students.SelectMany(student => student.Grades).ToList();

            Console.WriteLine("All grades from all students:");
            foreach (var grade in allGrades)
            {
                Console.WriteLine(grade);
            }

            //e
            var orderStudentsByAge = students.OrderByDescending(student => student.Age).ToList();

            Console.WriteLine("Array students by age:");
            foreach (var student in orderStudentsByAge)
            {
                Console.WriteLine(student.Name);
            }

        }
    }
}
