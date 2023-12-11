namespace _06._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> compnies = new Dictionary<string,List<string>>();

            string input = Console.ReadLine();

            while(input != "End")
            {
                string company = input.Split(" -> ")[0];
                string employeeId = input.Split(" -> ")[1];

                if(!compnies.ContainsKey(company))
                {
                    compnies.Add(company, new List<string>());
                   
                }
               
                    if (!compnies[company].Contains(employeeId))
                    {
                        compnies[company].Add(employeeId);
                    }
                   

                input = Console.ReadLine();
            }

            foreach(var company in compnies)
            {
                Console.WriteLine(company.Key);
                foreach(var employee in company.Value)
                {
                   Console.WriteLine($"-- {employee}");
                }
                
            }
        }
    }
}