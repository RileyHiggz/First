using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class Game
    {
        bool loop = true;
        Random NumberGenerator = new Random();
        public void RunGame()
        {
            while (loop == true)
            {
                Console.WriteLine("What is your name?");
                string UserInput = Console.ReadLine();
                int PowerLevel = NumberGenerator.Next(1, 999);
                
                    Console.WriteLine("Greetings " + UserInput);
                Console.WriteLine("Your power level is... " + PowerLevel);
                if(PowerLevel > 500)
                {
                    Console.WriteLine("Congrats you beat Frieza");
                }
                else
                {
                    Console.WriteLine("Unfortunatly you did not beat Frieza");
                }
                
                Console.WriteLine("Would you like to try again? Y/N ");
                string SecondInput = Console.ReadLine(); 
                if (SecondInput == "Y")
                {


                }
                else
                {
                    loop = false;
                }
                                 
               
            }
        }
    }
}
