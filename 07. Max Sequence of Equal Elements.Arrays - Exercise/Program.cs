using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements.Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()// 1 1 2 3 3 2 2 2 1
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            
            int bigestCounter = 0;
            int bigestindex=0;
            for (int i = 0; i < array.Length; i++)
            {
                int equalcoupleNums = 1;
                int firstNum=array[i];  


                for (int j = i+1; j < array.Length; j++)
                {

                    int nexNum = array[j];
                    if (firstNum == nexNum)
                    {
                        equalcoupleNums++;


                    }

                    else
                    {
                        
                        break;

                    }
                    if(equalcoupleNums>bigestCounter)
                    {
                        bigestCounter = equalcoupleNums;
                        bigestindex = array[i];
                    }

                }
            }


            for (int i = 0; i < bigestCounter; i++)
            {
                Console.Write( bigestindex+" ");
            }

        }
    }
}
