using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basisprogrammering___FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variabels
            bool gameRun = true;
            string userInput;
            string pcInput = " ";
            int userWin = 0;
            int pcWin = 0;

            //Game pressentation
            Console.WriteLine("You gonna play Stone-Scissor-Paper against the pc.");
            Console.WriteLine("Stone win over scissor, scissor over paper and paper over stone.");
            Console.WriteLine("If you want to quit write quit");
            while (gameRun)
            {

                Console.WriteLine("Choose between stone, scissor or paper");

                //Quit the game
                userInput = Console.ReadLine().ToLower();
                if (userInput == "quit")
                {
                    gameRun = false;
                }

                //Generat random 
                Random random = new Random();
                int randomNumber = random.Next(2, 4);

                //Switch for pcInput
                switch (randomNumber)
                {
                    case (1):
                        pcInput = "stone";
                        break;
                    case (2):
                        pcInput = "scissor";
                        break;
                    case (3):
                        pcInput = "paper";
                            break;
                }

                // The rulls for wining for user
                if (userInput == "stone" && pcInput == "scissor")
                {
                    Console.WriteLine("Stone win over scissor, you win");
                    userWin++;
                }
                if (userInput == "scissor" && pcInput == "paper")
                {
                    Console.WriteLine("Scissor win over paper, you win");
                    userWin++;
                }
                if (userInput == "paper" && pcInput == "stone")
                {
                    Console.WriteLine("Paper win over stone, you win");
                    userWin++;
                }
                //The rulls for losing for user
                if (userInput == "scissor" && pcInput == "stone")
                {
                    Console.WriteLine("Stone win over scissor, you lose");
                    pcWin++;
                }
                if (userInput == "paper" && pcInput == "scissor")
                {
                    Console.WriteLine("Scissor win over paper, you lose");
                    pcWin++;
                }
                if (userInput == "stone" && pcInput == "paper")
                {
                    Console.WriteLine("Paper win over stone, you lose");
                    pcWin++;
                }
                if (pcInput == userInput)
                {
                    Console.WriteLine("It¨s a tie");
                }

                //Ending message and score
                Console.WriteLine($"Your score {userWin} - PC score {pcWin}");
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
