using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeecolection = new List<Employee>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmArg[0];
                double salary = double.Parse(cmArg[1]);
                string department = cmArg[2];

                Employee employee = new Employee
                {
                    Name = name,
                    Salary = salary,
                    Deparment = department,

                };
                employeecolection.Add(employee);

            }

        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string  Deparment { get; set; }
    }
}
