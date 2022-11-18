using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> colection
                = new Dictionary<string, List<string>>();

            string cmnd;
            while ((cmnd = Console.ReadLine()) != "End")//SoftUni -> AA12345
            {

                string[] info = cmnd.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = info[0];   //SoftUni
                string employeeId = info[1];   //AA12345
                if (!colection.ContainsKey(companyName))
                {
                    colection[companyName] = new List<string>();
                    colection[companyName].Add(employeeId);
                }
                else
                {
                    if (!colection[companyName].Contains(employeeId))
                        

                    colection[companyName].Add(employeeId);
                }

            }


            foreach (var item in colection)
            {
                string companyName = item.Key;
                List<string> employeeId = item.Value;
                Console.WriteLine(companyName);
                foreach (var employee in employeeId)
                {
                    Console.WriteLine($"-- {employee}");
                }

            }
        }
    }
}
