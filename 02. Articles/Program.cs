using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string[] inputArticle = Console.ReadLine().Split(", ");
            int numberOfLines = int.Parse(Console.ReadLine());

            Article article = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(": ");

                if (input[0] == "Edit")
                {
                    article.Content = input[1];
                }

                else if (input[0] == "ChangeAuthor") 
                { 
                    article.Author = input[1];
                }

                else if (input[0] == "Rename")
                {
                    article.Title = input[1];
                }
            }

            Console.Write(article.ToString());
        }

        class Article 
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;  
            }
            public override string ToString() =>
                $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
