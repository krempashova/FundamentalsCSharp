using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student>colectionStudents = new List<Student>();
           int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //"{first name} {second name} {grade}"
                string[] studentInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student()
                {
                    FisrtName=studentInfo[0].Trim(),//Lakia
                    LastName=studentInfo[1].Trim(),//Eason
                    Grade=double.Parse(studentInfo[2].Trim()),//5.49
                     
                };
                colectionStudents.Add(student);

            }


            colectionStudents = colectionStudents.OrderByDescending(s => s.Grade).ToList();
            foreach (Student student in colectionStudents)
            {
                Console.WriteLine(student);
            }
        }
        
            
}
    public class Student
    {
        public string  FisrtName { get; set; }
        public string  LastName { get; set; }
        public double  Grade { get; set; }
        public override string ToString()
        {
            return $"{FisrtName} {LastName}: {Grade:F2}";
        }
    }
}
