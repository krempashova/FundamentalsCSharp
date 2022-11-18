namespace _04._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string cmnArg;
            while ((cmnArg = Console.ReadLine()) != "end")
            {
                string[] input = cmnArg.Split(" ", StringSplitOptions.RemoveEmptyEntries); //John Smith 15 Sofia
                string firstname = input[0]; //John
                string lastname = input[1];//Smith
                int age = int.Parse(input[2]);//15
                string hometown = input[3];//Sofia


                Student student = new Student()

                {
                    FirstName = firstname,
                    LastName = lastname,
                    Age = age,
                    HomeTown = hometown
                };
                if (StudentExist(students, student.FirstName, student.LastName, student.Age, student.HomeTown))
                {

                }
                else
                {
                    students.Add(student);
                }


            }


            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        private static bool StudentExist(List<Student> students, string firstName, string lastName, int age, string town)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    student.Age = age;
                    student.HomeTown = town;
                    return true;
                }
            }
            return false;
        }
    }

}

public class Student

{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}


