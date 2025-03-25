namespace Task_20_01
{
    internal class Program
    {
        /*Создайте enum для дней недели (Monday–Sunday). Напишите программу, которая:
• Принимает от пользователя число (1–7). 
• Преобразует его в день недели. 
• Выводит сообщение:
• "Будний день" (для Monday–Friday). 
• "Выходной" (для Saturday, Sunday).
        */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выведите число от 1 до 7 включительно");
                int UserEnter = Convert.ToInt32(Console.ReadLine());
                WeekDay day = (WeekDay)UserEnter;
                Console.WriteLine(day.ToString());

                switch (day)
                {
                    case WeekDay.Monday:
                    case WeekDay.Tuesday:
                    case WeekDay.Wednesday:
                    case WeekDay.Thursday:
                    case WeekDay.Friday:
                        Console.WriteLine("Будний день");
                        break;
                    case WeekDay.Saturday:
                    case WeekDay.Sunday:
                        Console.WriteLine("Выходной");
                        break;
                    default:
                        Console.WriteLine("Недопустимое значение");
                        break;
                }
            }
        }
    }
}
