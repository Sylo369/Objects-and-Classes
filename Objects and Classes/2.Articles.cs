using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Program
    {
        static void Test() 
        {
            List<string> input = Console.ReadLine()
                .Split(", ")                
                .ToList();

            Article article = new Article(input[0], input[1], input[2]);

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                List<string> commandLine = Console.ReadLine()
                    .Split(": ")
                    .ToList();
                string command = commandLine[0];
                string editedText = commandLine[1];

                

                switch (command)
                {
                    case "Edit":
                        {
                            article.Edit(editedText);
                            continue;
                        }
                    case "ChangeAuthor":
                        {
                            article.ChangeAuthor(editedText);
                            continue;
                        }
                    case "Rename":
                        {
                            article.Rename(editedText);
                            continue;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }

            article.ToString();

        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(string content)
        {
            Content = content;
            return Content;
        } 
        public string ChangeAuthor(string author)
        {
            Author = author;
            return Author;
        } public string Rename(string title)
        {
            Title = title;
            return Title;
        }
        public void ToString()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }

    }
}
