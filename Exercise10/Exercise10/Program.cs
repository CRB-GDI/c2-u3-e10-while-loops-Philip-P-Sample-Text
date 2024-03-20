using System;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberResponse = 0;
            
            //This while loop will stop when the input is 4, which will quit the game.
            while (numberResponse  != 4)
            {
                //Prints menu.
                Console.WriteLine();
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                Console.WriteLine();
                Console.WriteLine("Please select an option by typing one of the numbers.");

                //Parses the user input response.
                numberResponse = int.Parse(Console.ReadLine());

                //These if statements write the appropriate answer to the input value.
                if (numberResponse == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Making a new game...");
                }
                else if (numberResponse == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Loading game...");
                }
                else if (numberResponse == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Loading options...");
                }
                else if (numberResponse > 4 || numberResponse < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please input a valid number.");
                }
            }

            //"Quitting..." will be printed when the entire while loop is untrue.
            Console.WriteLine();
            Console.WriteLine("Quitting...");
        }
    }
}