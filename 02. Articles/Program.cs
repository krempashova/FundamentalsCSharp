using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //some title, some content, some author
            string[] manupulate = Console.ReadLine() // some title |some content| some author
                .Split(", ",StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article()
            {
                Title = manupulate[0],
                Content = manupulate[1],
                Author = manupulate[2],
            };
            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] cmnArg = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries);//•"Edit:| {new content}"
                string info = cmnArg[0];
                
                if(info== "Edit")
                {
                    article.Content = cmnArg[1];

                }
                else if(info== "ChangeAuthor")
                {
                    article.Author = cmnArg[1];
                }
                else if(info=="Rename")
                {
                    article.Title = cmnArg[1];
                }
            }
           
                
                  Console.WriteLine(article);



        }
    }
    public class Article
    {
      
            
        public string  Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
        public override string ToString()
        {
           return $"{Title} - {Content}: {Author}";
        }
    }
    
}
