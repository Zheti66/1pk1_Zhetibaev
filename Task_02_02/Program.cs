namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 14;
            double c = Math.PI / 4;
            double one = Math.Pow(a - 1, 1.0 / 3.0);
            double two = Math.Pow(b + one, 1.0 / 4.0);
            double three = Math.Abs(a - b);
            double four = Math.Sin(c);
            double five = Math.Pow(four, 2);
            double six = Math.Tan(c);

            double result = two / (three * (five + six));
            Console.WriteLine(result);

        }
    }
}
