using System;

namespace _03._Vacation_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int numPeopleGoing=int.Parse(Console.ReadLine());//30
            string typeOfGroup=Console.ReadLine();//sTUDENTS
            string DayOfTheWeek = Console.ReadLine();//sUNDAY
            double priceForaLLGroup = 0;
            double discound = 0;
            double priceForEach = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    if(DayOfTheWeek=="Friday")
                    {
                        priceForaLLGroup = numPeopleGoing * 8.45;
                    }
                    else if(DayOfTheWeek=="Saturday")
                    {
                        priceForaLLGroup =numPeopleGoing* 9.80;
                    }
                    else if(DayOfTheWeek=="Sunday")
                    {
                        priceForaLLGroup =numPeopleGoing* 10.46;
                    }
                    if(numPeopleGoing>=30)
                    {
                        discound = priceForaLLGroup * 0.15;
                        priceForaLLGroup -= discound;
                    }
                    break;

                case "Business":
                    if (DayOfTheWeek == "Friday")
                    {
                        priceForEach = 10.90;
                        priceForaLLGroup =numPeopleGoing * 10.90;
                    }
                    else if (DayOfTheWeek == "Saturday")
                    {
                        priceForEach = 15.60;
                        priceForaLLGroup =numPeopleGoing * 15.60;
                    }
                    else if (DayOfTheWeek == "Sunday")
                    {
                        priceForEach = 16.00;
                        priceForaLLGroup =numPeopleGoing * 16.00;
                    }
                    if(numPeopleGoing>=100)
                    {
                        discound = 10 * priceForEach;
                        priceForaLLGroup -= discound;
                    }
                    break;

                case "Regular":
                    if (DayOfTheWeek == "Friday")
                    {
                        priceForaLLGroup = numPeopleGoing * 15.00;
                    }
                    else if (DayOfTheWeek == "Saturday")
                    {
                        priceForaLLGroup = numPeopleGoing * 20.00;
                    }
                    else if (DayOfTheWeek == "Sunday")
                    {
                        priceForaLLGroup = numPeopleGoing * 22.50;
                    }
                    if(numPeopleGoing>=10 && numPeopleGoing<=20)
                    {
                        discound = priceForaLLGroup * 0.05;
                        priceForaLLGroup -= discound;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {priceForaLLGroup:F2}");
           

        }
    }
}
