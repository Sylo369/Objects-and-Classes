using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Classes
{
    public class Program
    {
        static void Test()
        {
            int numArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < numArticles; i++)
            {
                List<string> input = Console.ReadLine()
               .Split(", ")
               .ToList();              

                articles.Add(new Article(input[0], input[1], input[2]));
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "title":
                    articles = articles.OrderBy(a => a.Title).ToList();                  
                    break;
                case "content":
                    articles = articles.OrderBy(a => a.Content).ToList();                  
                    break;
                case "author":
                    articles = articles.OrderBy(a => a.Author).ToList();                  
                    break;
                default:
                    break;
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

 
