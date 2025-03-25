namespace Task_10_05
{
    internal class Program
    {
        /*Пользователь вводит целое неотрицательное число n, 
         * программа с помощью процедурных методов должна 
         * рассчитать и вывести площадь окружности с радиусом n 
         * объем и площадь сферы с радиусом n 
         * 
         * Осуществите бесконечный цикл для консольного 
         * ввода числа и вызова метода 
         * с выводом информации по выходноу параметру 
         */
        static void Main(string[] args)
        {
           
        }
        static void PrintSphereCircleData(int r)
        {
            double sphereVolume = 4 / 3.0 * Math.PI * Math.Pow(2, r);
            double sphereArea = 4 * Math.PI * Math.Pow(r, 2);
            double circleArea = Math.PI * r * r;

            Console.WriteLine($"Объем сферы: {sphereVolume}");
            Console.WriteLine($"Площадь сферы: {sphereArea}");
            Console.WriteLine($"Площадь круга: {circleArea}");
        }
    }
}
