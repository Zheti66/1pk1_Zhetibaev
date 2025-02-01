namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            // Принятие данных
            Console.WriteLine("Начальная температура в градусах Цельсия: ");
            string start = Console.ReadLine();
            double starts = Convert.ToDouble(start);

            Console.WriteLine("Конечная температура в градусах Цельсия: ");
            string end = Console.ReadLine();
            double ends = Convert.ToDouble(end);

           
            Console.WriteLine("Шаг изменения температуры: ");
            string step = Console.ReadLine();
            double steps = Convert.ToDouble(step);

            // Вывод заголовка таблицы
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("  Цельсий |  Фаренгейт ");
            Console.WriteLine("--------------------------");


            // Вывод таблицы температур
            for (double celsius = starts; celsius <= ends; celsius += steps)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius,8:F2} | {fahrenheit,10:F2}");
            }

            Console.WriteLine("--------------------------");

            Console.ReadKey();
        }
    }
}
