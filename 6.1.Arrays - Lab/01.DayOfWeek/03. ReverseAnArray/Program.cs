namespace _03._ReverseAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n]; 
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine(string.Join(", ",arr));

            for(int i = n-1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}