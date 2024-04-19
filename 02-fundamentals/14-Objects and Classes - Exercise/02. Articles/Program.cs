using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            string title = input[0];
            string content = input[1];
            string author = input[2];
            Article article = new Article(title, content, author);

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine().Split(": ").ToArray();
                string command = info[0];
                string newContent = info[1];

                if (command == "Edit")
                {
                    article.Content = newContent;
                } else if (command == "ChangeAuthor")
                {
                    article.Author = newContent;
                } else if (command == "Rename")
                {
                    article.Title = newContent;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    class Article
    {
        public string Title {get; set;}
        public string Content {get; set;}
        public string Author {get; set;}
    
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void changeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}






