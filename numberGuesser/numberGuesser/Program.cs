using System;

// Namespace
namespace numberGuesser
{
    // Main Class
    class MainClass
    {
        //Entry Point Method
        public static void Main(string[] args)
        {
            GetAppInfo(); // Run function to get info.

            GreetUser(); // Ask for user name and greet.

            while (true)
            {

                // Set correct number
                //int correctNumber = 7
                //Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // guess var
                int guess = 0;

                // Ask user for #
                Console.WriteLine("Guess a number between 1 and 10.");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    //cast int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        //Print error message
                        printColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                // Output success message
                if (guess == correctNumber)
                {
                    //Print correct message
                    printColorMessage(ConsoleColor.Yellow, "You are CORRECT!");

                    // Ask to play again
                    Console.WriteLine("Play again? [Y or N]");

                    //Get answer
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Truly Klingler";

            //Change text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }

        //Ask user name and greet.
        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message.
        static void printColorMessage(ConsoleColor color, string message)
        {
            //Change text Color
            Console.ForegroundColor = color;

            // Give user message
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
