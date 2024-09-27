namespace Rock_Paper_Scissors
{
    internal class Program
    {
        enum Choises { Rock = 1,Scissors = 2, Paper = 3 }
        static Choises playerChoice = 0;
        static Choises computerChoice = 0;
        static void MakePlayerChoice()
        {
            Console.WriteLine("1.Камень\n2.Ножницы\n3.Бумага");
            Console.Write("Введите выбор: ");
            try
            {
                playerChoice =(Choises)int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void MakeComputerChoice()
        {
            Console.WriteLine("Выбор компьютера");
            Random rand = new Random();
            computerChoice = (Choises)rand.Next(1,4);
        }

        static void Game()
        {
            Console.WriteLine("Камень ножницы бумага");
            int choice = 1;
            do
            {
                try
                {
                    MakePlayerChoice();
                    MakeComputerChoice();
                    Console.WriteLine($"Выбор игрока: {playerChoice}");
                    Console.WriteLine($"Выбор компьютера: {computerChoice}");
                    if (playerChoice == computerChoice)
                    {
                        Console.WriteLine("Ничья");
                    }
                    else if (playerChoice == Choises.Scissors && computerChoice != Choises.Rock)
                    {
                        Console.WriteLine("Игрок победил");
                    }
                    else if (playerChoice == Choises.Rock && computerChoice != Choises.Paper)
                    {
                        Console.WriteLine("Игрок победил");
                    }
                    else if (playerChoice == Choises.Paper && computerChoice != Choises.Scissors)
                    {
                        Console.WriteLine("Игрок победил");
                    }
                    else
                    {
                        Console.WriteLine("Компьютер победил");
                    }
                    Console.WriteLine("Хотите повторить ?\n 1.Да\n 2.Нет");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.ToString());
                }
            } 
            while (choice != 2);
        }

        static void Main(string[] args)
        {
            Game();
        }
    }
}
