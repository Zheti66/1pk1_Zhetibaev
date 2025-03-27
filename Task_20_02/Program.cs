namespace Task_20_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделайте выбор от 1 до 3: \n 1 - Камень \n 2 - Ножницы \n 3 - Бумага");

            while (true)
            {
                Random random = new Random();
                GameChoice computer = (GameChoice)random.Next(1, 4);

                int player = Convert.ToInt32(Console.ReadLine());
                GameChoice player1 = (GameChoice)player;

                string result = DetermineWinner(player1, computer);
                Console.WriteLine(result);

            }
        } 
            
            
        static string DetermineWinner(GameChoice player, GameChoice computer)
        {
            if (player == computer)
                return "Ничья!";

            switch (player)
            {
                case GameChoice.Rock:
                    return computer == GameChoice.Scissors ? "Вы победили!" : "Компьютер победил!";
                case GameChoice.Scissors:
                    return computer == GameChoice.Paper ? "Вы победили!" : "Компьютер победил!";
                case GameChoice.Paper:
                    return computer == GameChoice.Rock ? "Вы победили!" : "Компьютер победил!";
                default:
                    return "Ошибка определения победителя";
            }
        }
    }
}
