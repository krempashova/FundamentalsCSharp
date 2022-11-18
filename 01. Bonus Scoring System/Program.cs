using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int numOflectures = int.Parse(Console.ReadLine());
            int additionalBonus=int.Parse(Console.ReadLine());
            double MaxBonus = 0;
            double winnerattendence = 0;
            for (int i = 1; i <=studentsCount; i++)
            {
                double attendenceofEachStudents = double.Parse(Console.ReadLine());
                ///{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})
                double totalBonus=(attendenceofEachStudents / numOflectures) * (5.00 + additionalBonus);
                if(totalBonus>MaxBonus)
                {
                    MaxBonus = totalBonus;
                    winnerattendence = attendenceofEachStudents;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(MaxBonus)}.");
            Console.WriteLine($"The student has attended {winnerattendence} lectures.");

        }
    }
}
