namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string target = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(target))
            {

                //int index = text.IndexOf(target);
                //text = text.Remove(index,target.Length);

                text = text.Replace(target, "");
               
            }
            

            Console.WriteLine(text);
        }
    }
}