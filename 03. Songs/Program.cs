namespace _03._Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Songs>songs = new List<Songs>();

            int numSongs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numSongs; i++)
            {
                string[] cmnArg = Console.ReadLine()  
                    .Split("_", StringSplitOptions.RemoveEmptyEntries);
                string type = cmnArg[0];
                string name = cmnArg[1];
                string time = cmnArg[2];
               
                Songs song = new Songs(type,name,time);
                songs.Add(song);

            }

            string typeList = Console.ReadLine();
              if(typeList=="all")
            {
                foreach(Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }

            }
            else
            {
                foreach(Songs song in songs)
                {
                    if(song.TypeList==typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
                        

            }

        }
    }
    public class Songs
    {
        public Songs(string typeList, string name, string time)
            {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;

            }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}


