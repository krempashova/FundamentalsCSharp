using System;

namespace _10.PokeMon.DataTypesVariables.ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());//1000
            int M = int.Parse(Console.ReadLine());//50
            int Y = int.Parse(Console.ReadLine());//2
            int NReadyForDivide = N;
            int targetCount = 0;
            while (N>=M)
            {


                
                    N -= M;
                    targetCount++;
                
                if (N == NReadyForDivide*0.50 && Y != 0)
                {
                    N /= Y;
                    
                        
                }

            }
            Console.WriteLine(N);
            Console.WriteLine(targetCount);
          
               
            
        }
    }
}
