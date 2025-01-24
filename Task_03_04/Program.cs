namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int LineCount = 0;
            do
            {
                Console.WriteLine("Ведите текст: ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.ToLower() != "exit")
                {
                    LineCount++;
                }
                Console.Clear();
            }
            while (!string.IsNullOrEmpty(input) && input.ToLower() != "exit");
            Console.WriteLine($"Количество введеных строк: {LineCount}");


        }
    }
}
