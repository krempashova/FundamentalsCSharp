using System;

namespace _01._Bonus_Scoring_SystemMIDeXAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numStudents = double.Parse(Console.ReadLine());
            double numLecturs = double.Parse(Console.ReadLine());
            double aditionalBonus=double.Parse(Console.ReadLine());
            double maxBonus = 0;
            double  studentattendancesMax = 0;
            for (int i = 0; i < numStudents; i++)
            {
                double studentsAtendances=double.Parse(Console.ReadLine());

               double totalBonus =(double) studentsAtendances / (numLecturs) * (5 + aditionalBonus);
                if(totalBonus>maxBonus)
                {
                    maxBonus = totalBonus;
                    studentattendancesMax = studentsAtendances;
                }

                maxBonus = Math.Round(maxBonus);
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {studentattendancesMax} lectures.");
            
        }
    }
}
                                                                                                                                     