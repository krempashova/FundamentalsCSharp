using System;
using System.Collections.Generic;

namespace _03._The_Pianistexams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pieces
                = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string comnad = Console.ReadLine();
                string[] cmnArg = comnad.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piecename = cmnArg[0];
                string composer = cmnArg[1];
                if()




            }




        }
    }
}
