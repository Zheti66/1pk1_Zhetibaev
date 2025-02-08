namespace Task_10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введитет число n и программа вычислит сумму факториалов всех чисел до числа n");
            int n = Convert.ToInt32(Console.ReadLine());

            long fact = 0;
            while (n > 0)
            {
                fact += Factorial(n);
                n--;
            }

            Console.WriteLine($"сумма факториалов до числа n: {fact}");
        }
        public static long Factorial(int k)
        {
            long result = 1;
                for (int i = 1; i <= k; i++)
                    result *= i;
            return result;  

        }
    }
}
