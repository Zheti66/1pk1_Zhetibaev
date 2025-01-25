using System.ComponentModel.Design;

namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            Console.WriteLine("Введите год своего рождения: ");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Введите год в виде числа.");
            }
            Console.WriteLine("Введите месяц своего рождения: ");
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Введите число от 1 до 12.");
            }
            Console.WriteLine("Введите день рождения:");
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                Console.WriteLine($"Введите день в виде числа от 1 до {DateTime.DaysInMonth(year, month)}.");

            }
            DateTime dateTime = DateTime.Now;
            DateTime birthDate = new DateTime(year, month, day);
            int age = dateTime.Year - birthDate.Year;
            if (dateTime.Month < birthDate.Month || (dateTime.Month == birthDate.Month && dateTime.Day < birthDate.Day));
            {
                age--;
            }
            if (age >= 18) 
            {
                Console.WriteLine("Вы совершеннолетний");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний.");
            }
            Console.ReadKey();

        }
        
    }
}
