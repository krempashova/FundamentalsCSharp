using System;
using System.Linq;


namespace _10._LadyBugs.Array.exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeFiled = int.Parse(Console.ReadLine());//size of filed

            //2.create empty array, with size =filed
            int[] field = new int[sizeFiled];

            
               int[] initialindex = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

               foreach(int index in initialindex)
            {
                if(index>=0&& index<field.Length)
                {
                    field[index] = 1;
                }
                        
            }
                   string input;
               while((input=Console.ReadLine())!="end")
            {
                string[] inputArg = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int ladybugIndex=int.Parse(inputArg[0]);
                string direction = inputArg[1];
                int flylenhgt = int.Parse(inputArg[2]);
                if(ladybugIndex<0 || ladybugIndex>=field.Length)
                {
                    continue;
                }
                if(field[ladybugIndex]==0)
                {
                    continue;
                }
                
                field[ladybugIndex] = 0;
                if(direction=="left")
                {
                    flylenhgt *= -1;
                }
                int nextindex = ladybugIndex + flylenhgt;  
                while(nextindex>=0 && nextindex<sizeFiled &&field[nextindex]==1)
                {
                    nextindex += flylenhgt;
                }
                if(nextindex<0 || nextindex>=field.Length)
                {
                    continue;
                }
                field[nextindex] = 1;
            }





            Console.WriteLine(String.Join(" ", field));


        }
    }
}
