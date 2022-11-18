using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = Console.ReadLine()    //Ivo Johny Tony Bony Mony
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            string comand;
            while((comand=Console.ReadLine())!="3:1")

            {
                string[] words = comand.Split(" ");
                string manipulator=words[0];
                if(manipulator=="merge")
                {
                    int startIndex = int.Parse(words[1]);
                    int endIndex = int.Parse(words[2]);
                    if(startIndex <0 || startIndex>letters.Count || endIndex>letters.Count ||endIndex<0)
                    { 
                        startIndex = 0;
                        endIndex = letters.Count-1;   
                    }

                    letters[startIndex] = letters[startIndex] + letters[endIndex];
                    letters.RemoveAt(endIndex);

                   


                }
                else if(manipulator=="divide")
                {
                    int index = int.Parse(words[1]);
                    int partition = int.Parse(words[2]);

                }
            }
        }
    }
}
