using System;

namespace p09Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            double Johnamount = double.Parse(Console.ReadLine());//100
            int studentsNum=int.Parse(Console.ReadLine());//42
            double pricelightsabers=double.Parse(Console.ReadLine());//1
            double RobesPrice = double.Parse(Console.ReadLine());//2
            double BeltsPrice = double.Parse(Console.ReadLine());//3

            double totalForLightsabers = studentsNum + (studentsNum * 0.10);
            totalForLightsabers = Math.Ceiling(totalForLightsabers);
            double moneyLightsaber = totalForLightsabers * pricelightsabers;
            double moneyrobes = studentsNum * RobesPrice;
            double neededbelst = studentsNum / 6;
            double moneybelts = (studentsNum-neededbelst) * BeltsPrice;
            double totalforall = moneyLightsaber + moneyrobes + moneybelts;
            if(Johnamount>=totalforall)
            {
                Console.WriteLine($"The money is enough - it would cost {totalforall:f2}lv.");
            }
            else
            {
                double neddedMoney = totalforall - Johnamount;             
                    Console.WriteLine($"John will need {neddedMoney:F2}lv more.");
            }
        }
    }
}
