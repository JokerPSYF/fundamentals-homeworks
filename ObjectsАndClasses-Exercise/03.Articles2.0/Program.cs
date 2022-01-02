using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace _02.Articles
{
    class Program

    {

        class Article
        {
            public string Title { get; set; }

            public string Content { get; set; }

            public string Author{ get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(", ");
                string title = line[0];
                string content = line[1];
                string author = line[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string orderBy = Console.ReadLine();
            switch (orderBy)
            {
                case "title":
                    foreach (Article article in articles.OrderBy(x => x.Title))
                    {
                        Console.WriteLine(article);
                    }
                    break;

                case "content":
                    foreach (Article article in articles.OrderBy(x => x.Content))
                    {
                        Console.WriteLine(article);
                    }
                    articles.OrderByDescending(x => x.Content);
                    break;

                default:
                    foreach (Article article in articles.OrderBy(x => x.Author))
                    {
                        Console.WriteLine(article);
                    }
                    break;
            }
        }
    }
}
/* Задачата е подобна като втората само че трябва да направим метод от лист в който да запаметим заглавието, темата и автора от инпута.
 След това да да искараме всичко по реда по който са ни дали в инпута*/ 