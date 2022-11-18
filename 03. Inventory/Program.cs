using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries) //Iron, Wood, Sword
                 .ToList();

            string comand;
            while((comand=Console.ReadLine())!="Craft!")
            {
                string[] todo = comand.Split("-"); //Collect - Gold

                string name=todo[0];    
                if(name=="Collect")
                {
                    string items = todo[1];
                    if(!journal.Contains(items))
                    {
                        journal.Add(items); 
                    }

                }
                else if(name=="Drop")
                {
                    string items = todo[1];
                    if(journal.Contains(items))
                    {
                        journal.Remove(items);
                    }
                }
                else if(name=="Combine Items")  //Combine Items - Sword:Bow
                {
                    string[] items = todo[1].Split(":",StringSplitOptions.RemoveEmptyEntries);
                    string olditems = items[0];  //sword
                    string newitems = items[1];  // bow
                    if(journal.Contains(olditems))
                    {
                        int index = journal.IndexOf(olditems);
                        journal.Insert(index + 1, newitems);
                    }

                                                               
                }
                else if(name=="Renew")
                {
                    string items = todo[1];
                    if(journal.Contains(items))
                    {
                        journal.Add(items);
                        journal.Remove(items);
                    }

                }

            }
            Console.WriteLine(string.Join(", ",journal));

        }
    }
}
