using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]targets=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)//24 50 36 70
                .ToArray();
            int shotcount = 0;
            string input;
            while((input=Console.ReadLine())!="End")
            {
                int index=int.Parse(input); //0
                //1.valide index if is invalid continue reading;dont do enything;
                if(index<0 || index>targets.Length-1)
                {
                    continue;
                }
                else
                { //2.Shot Target
                    if(targets[index]==-1)
                    {
                        break;
                    }                  
                    int targetvalue = targets[index]; //24
                    targets[index] = -1;
                    IncreaseReduceTargets(targets, index, targetvalue);
                    shotcount++;
                }
                 
            }

            Console.WriteLine($"Shot targets: {shotcount} -> " + string.Join(" ", targets));
        }

      static void IncreaseReduceTargets(int[] targets, int index, int targetvalue)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                if(targets[i]<=targetvalue && targets[i]!=-1)
                {
                    targets[i] += targetvalue;
                }
                else if(targets[i]>targetvalue && targets[i]!=-1)
                {
                    targets[i] -= targetvalue;
                }
            }


        }

       
    }
}
