using System;

namespace First
{
    class Program
    {
        static Game OurGame;
        static void Main(string[] args)
        {
            OurGame = new Game();
            OurGame.RunGame();
            Console.WriteLine("First Project");
        }
    }
}
