using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studetnsInfo = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            // receive n time stident Name & grade
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine(); //JOHN
                double grade = double.Parse(Console.ReadLine());//5.00
                //chek if name exist and if no addhima
                if (!studetnsInfo.ContainsKey(name))
                {
                    studetnsInfo.Add(name, new List<double>());
                    studetnsInfo[name].Add(grade);
                }

                else
                {
                    studetnsInfo[name].Add(grade);
                }
            }
            foreach (var item in studetnsInfo)
            {
                double averageGrade = item.Value.Average();
                
                if(averageGrade>=4.50)
                {
                    Console.WriteLine($"{item.Key} -> {averageGrade:f2}");
                }
            }

            

            }
        }
    }


