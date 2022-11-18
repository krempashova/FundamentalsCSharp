using System;

namespace _01._Experience_Gaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int batlleCount = 0;
            decimal sumofexp= 0m;
            decimal neededExperience = decimal.Parse(Console.ReadLine());
            decimal countbattlets = decimal.Parse(Console.ReadLine());
            for (int i = 1; i <=countbattlets; i++)
            {
                batlleCount++;
                decimal experienceearnpERBattle=decimal.Parse(Console.ReadLine());
                if(i%3==0 && i!=0)
                {
                    experienceearnpERBattle = (experienceearnpERBattle * 0.15m) + experienceearnpERBattle;
                    sumofexp += experienceearnpERBattle;
                     
                }
                else if(i%5==0)
                {
                    experienceearnpERBattle = experienceearnpERBattle - (experienceearnpERBattle * 0.10m);
                    sumofexp += experienceearnpERBattle;
                }
                else if(i%15==0)
                {
                    experienceearnpERBattle = (experienceearnpERBattle * 0.05m) + experienceearnpERBattle;
                    sumofexp += experienceearnpERBattle;
                }
                 else
                {
                    sumofexp += experienceearnpERBattle;
                }

                if(sumofexp>=neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {batlleCount} battles.");
                    return;
                }
            }

            decimal insuficientexp = neededExperience - sumofexp;
            Console.WriteLine($"Player was not able to collect the needed experience, {insuficientexp:f2} more needed.");

        }
    }
}
