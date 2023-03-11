using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int numberOfArticles = int.Parse(Console.ReadLine());
            List <Article> listOfArticles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] inputArticle = Console.ReadLine().Split(", ");
                Article article = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);
                listOfArticles.Add(article);
            }

            for (int i = 0;i < listOfArticles.Count;i++)
                Console.WriteLine(listOfArticles[i].ToString());
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
