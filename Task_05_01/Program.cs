namespace Task_05_01
{
    internal class Program
    {
        //У пользователя в консоли запрашивается число n, передается квадратрный массив целых чисел (n*n). 
        //Заполняется случайными числами в диапозоне от 10 до 99 включительно. После вывода на консоль сгенерированного массива
        //у пользователя запрашиваются номера строк дял заммены местами. После чего без очищения консоли выводится обновленный массив 
        //где строки, поменявшиеся местами выделены цветом 
          

        static void Main(string[] args)
        {
            Console.WriteLine("введите n - размер квадратного массива");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Число д.б. ,больше ннуля и целым");
                n = int.Parse(Console.ReadLine());
            }
            int[,] nums = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = random.Next(10, 100);
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nВыберите строки, чтобы поменять местами");
            int ind1 = int.Parse(Console.ReadLine()) - 1;
            int ind2 = int.Parse(Console.ReadLine()) - 1;
            int temp = 0;
            for(int j = 0; j < nums.GetLength(1); j++)
            {
                temp = nums[ind1, j];
                nums[ind1, j] = nums[ind2, j];
                nums[ind2, j] = temp;
            }
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                if (i == ind1 || i == ind2)
                    Console.BackgroundColor = ConsoleColor.Green;
                for (int j = 0;j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j]+ " ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }


        }     
    }
}
