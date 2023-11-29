namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            while(text != "end")
            {
                string reverseText = "";

                //for(int i = text.Length - 1; i >= 0; i--)
                //{
                //    reverseText += text[i];
                //}
                
                
                //char[] arr = text.ToCharArray();
                //Array.Reverse(arr);
                //reverseText = string.Join("",arr);


                reverseText = string.Join("", text.ToCharArray().Reverse());


                Console.WriteLine($"{text}" + " = " + $"{reverseText}");

               

                text = Console.ReadLine();
            }
        }
    }
}