namespace Rock_Paper_Scissors
{
    internal class Program
    {
        enum Choises { Rock = 1,Paer = 2,Scissors = 3}
        static int playerChoice = 0;
        static int computerChoice = 0;
        static void MakePlayerChoice()
        {
            Console.WriteLine("1.Камень\n2.Ножницы\n3.Бумага");
            Console.Write("Введите выбор: ");
            try
            {
                playerChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void MakeComputerChoice()
        {
            Console.Write("Выбор компьютера");
            Random rand = new Random();
            computerChoice = rand.Next(1,4);
        }

        static void Main(string[] args)
        {
            MakeComputerChoice();
        }
    }
}
