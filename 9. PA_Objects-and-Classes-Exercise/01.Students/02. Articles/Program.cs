namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

                string title = data.Split(", ")[0];
                string content = data.Split(", ")[1];
                string author = data.Split(", ")[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] commands = Console.ReadLine().Split(": ");
                string command = commands[0];
                string newtext = commands[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(newtext);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(newtext);
                        break;
                    case "Rename":
                        article.Rename(newtext);
                        break;

                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}