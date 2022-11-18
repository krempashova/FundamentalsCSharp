using System;

namespace _01.DataTypeFinder.Data_Types_and_Variables___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine())!="END")
            {
                string DataType = command;
                if (DataType == null)
                {
                   
                    Console.WriteLine($"{DataType} is strings type");
                }

                else if(DataType!=null)
                {
                    double valueDataType = double.Parse(DataType);
                   
                        if(valueDataType>= -2147483648 || valueDataType<= 2147483648)
                    {
                        Console.WriteLine($"{DataType} is integer  type");
                    }
                        else if(valueDataType>=1.10)
                    {
                        Console.WriteLine($"{DataType} is floating point  type");
                    }
                }

                
            }
            




        }
    }
}
