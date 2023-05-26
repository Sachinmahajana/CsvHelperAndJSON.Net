namespace CsvHelperAndJSON.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the csvhelper and json .net Program");
            Console.WriteLine("Please select the program given below");
            Console.WriteLine("\n1:Csv helper");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CSvOperation.CsvImplementFunction();
                    break;
            }
        }
    }
}