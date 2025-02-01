namespace Task_03_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Числа от 20 до 50, делящиеся на 3, но не делящиеся на 5: ");
            int nums = 20;
            while (nums <= 50)
            {
                if ((nums % 3 == 0) && (nums % 5 != 0))
                {
                    Console.Write(nums + " ");
                }
                nums++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
