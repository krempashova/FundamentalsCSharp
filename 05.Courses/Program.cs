using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> courseInfo = new Dictionary<string,List<string>>();    
            string cmnd;
            while((cmnd=Console.ReadLine())!="end")//Programming Fundamentals : John Smith
            {
                string[]comand=cmnd.Split(" : ");
                string courseName = comand[0];//Programming Fundamentals
                string studentName = comand[1];//John Smith
                if(!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName]=new List<string>();

                }
                courseInfo[courseName].Add(studentName);
            }
            foreach (var item in courseInfo)
            {
                string courseName = item.Key;
                List<string> studentName = item.Value;
                Console.WriteLine($"{courseName}: {studentName.Count}");
                foreach (var student in studentName)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
            


        }
    }
}
