using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonInfo> personinfocolection = new List<PersonInfo>();
            string command;
            while((command = Console.ReadLine()) !="End")//George 123456 20
            {
                string [] parts = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string firstname=parts[0];
                string id = parts[1];
                int age = int.Parse(parts[2]);

                PersonInfo personinfo = new PersonInfo
                {
                    FirstName = firstname,
                    ID = id,
                    Age = age,
                };
                personinfocolection.Add(personinfo);
            



        }

            personinfocolection = personinfocolection.OrderBy(x => x.Age).ToList();
            foreach (PersonInfo personinfo in personinfocolection)
            {
                Console.WriteLine($"{personinfo.FirstName} with ID: {personinfo.ID} is {personinfo.Age} years old.");
            }
        }
    }
    public class PersonInfo
    {
        
        public string FirstName { get; set; }
        public string  ID { get; set; }
        public int Age { get; set; }
    }
}
