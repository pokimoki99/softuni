using System;

namespace Second2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(", ");
            Arcticle arcticle = new Arcticle(token[0], token[1], token[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(": ");
                string command = cmdArg[0];
                string argument = cmdArg[1];
                switch (command)
                {
                    case "Edit":
                        arcticle.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        arcticle.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        arcticle.Reneme(argument);
                        break;
                }
            }
            Console.WriteLine(arcticle.ToString());
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
            public void Edit(string content)
            {
                Content = content;
            }
            public void ChangeAuthor(string author)
            {
                Author = author;
            }
            public void Reneme(string title)
            {
                Title = title;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
       
