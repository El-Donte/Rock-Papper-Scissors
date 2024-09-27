namespace Rock_Paper_Scissors
{
    internal class Program
    {
        enum Choises { Rock,Paer,Scissors}
        static int playerChoice = 0;
        static void PlayerChoice()
        {
            Console.WriteLine("1.Камень\n2.Ножницы\n3.Бумага");
            Console.Write("Введите выбопр: ");
            try
            {
                playerChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
