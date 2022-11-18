namespace _06._Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static decimal itemprice;

        static void Main(string[] args)
        {
            List<Box> boxList = new List<Box>();
            string cmnArg;
            while ((cmnArg = Console.ReadLine()) != "end")//
            {
                string[] info = cmnArg.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string serialNum = info[0];
                string itemname = info[1];
                int quantity = int.Parse(info[2]);
                decimal price = decimal.Parse(info[3]);

                Box box = new Box();
                box.Item = new Item()
                {
                    Name = itemname,
                    Price = price,
                };

                box.SerialNumber = serialNum;
                box.ItemQuantity = quantity;
                box.PriceofBox = box.Item.Price * box.ItemQuantity;

                boxList.Add(box);


            }


            List<Box> result = boxList.OrderByDescending(x => x.PriceofBox).ToList();
            foreach (Box box in result)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceofBox:f2}");
            }
        }

        public class Box
        {


            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceofBox { get; set; }



        }

        public class Item
        {

            public string Name { get; set; }
            public decimal Price { get; set; }
        }



    }
}