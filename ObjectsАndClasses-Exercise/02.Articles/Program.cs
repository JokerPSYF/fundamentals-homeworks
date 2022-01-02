using System;
using System.Dynamic;

namespace _02.Articles
{
    class Program

    {

        class Article
        {
            public string Title { get => title_; set => title_ = value; }

            public string Content { get => content_; set => content_ = value; }

            public string Author { get => author_; set => author_ = value; }

            private string title_;
            private string content_;
            private string author_;

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
            string[] line = Console.ReadLine().Split(", ", StringSplitOptions.None);
            int n = int.Parse(Console.ReadLine());
            string title = line[0];
            string content = line[1];
            string author = line[2];


            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                switch (cmd[0])
                {
                    case "Edit":
                        content = cmd[1];
                        break;

                    case "ChangeAuthor":
                        author = cmd[1];
                        break;

                    case "Rename":
                        title = cmd[1];
                        break;
                }
            }
            Article newArticle = new Article(title, content, author);


            Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
        }
    }
}
//Правим нов клас с конструктор. Приемаме входа чрез масив, после го равняваме с конструктора след това чрез while
// приемаме команди и манипулираме конструкторите
// Накрая извикваме класа