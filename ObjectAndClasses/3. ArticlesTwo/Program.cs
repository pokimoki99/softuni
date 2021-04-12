using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._ArticlesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Arcticle> arcticles = new List<Arcticle>();
            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split(", ");
                string title = token[0];
                string content = token[1];
                string author = token[2];
                Arcticle arcticle = new Arcticle(title, content, author);
                arcticles.Add(arcticle);
            }
            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                arcticles = arcticles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
                arcticles.Sort((c1, c2) => c1.Content.CompareTo(c2.Content));
            }
            else if (criteria == "author")
            {
                arcticles = arcticles.OrderBy(x => x.Author).ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine, arcticles));
        }
        class Arcticle
        {
            public Arcticle(string title, string content, string author)
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
}
