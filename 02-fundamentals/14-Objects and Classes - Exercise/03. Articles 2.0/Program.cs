using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                string title = input[0];
                string content = input[1];
                string author = input[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            foreach (var ar in articles)
            {
                Console.WriteLine(ar.ToString());
            }
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