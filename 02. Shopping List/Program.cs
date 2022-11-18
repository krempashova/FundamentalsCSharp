using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine() //Tomatoes!Potatoes!Bread
                .Split("!")
                .ToList();
            string command;
            while((command=Console.ReadLine())!="Go Shopping!")
            {
                string []arg=command.Split(" ");
                string words = arg[0];
              if(words=="Urgent")
                {
                    string item = arg[1];
                    if(!products.Contains(item))
                    {
                        products.Insert(0, item);
                    }
                }
              else if(words=="Unnecessary")
                {
                    string item = arg[1];
                    if(products.Contains(item))
                    {
                        products.Remove(item);
                    }
                                                              
                }
              else if(words=="Correct")
                {
                    string olditem = arg[1];
                    string newitem = arg[2];
                    
                 if (products.Contains(olditem))
                  {
                        int index = products.IndexOf(olditem);
                        products.Insert(index, newitem);
                        products.Remove(olditem);

                  }
                    
                }
              else if(words=="Rearrange")
                {
                    string item = arg[1];
                    if(products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }
                            
                }
              
            }
            Console.WriteLine(String.Join(", ",products));
        }
    }
}
