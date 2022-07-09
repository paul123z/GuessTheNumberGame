using System;

// namespace is a container for classes and functions, if you want to reference a specific class within a specific namespace -> u can do that

//variable = property
//function = method
namespace NumberGuesser
{
    //main class
    internal class Program
    {
        //void means that this functiong doesnt return anything
        //static means that we dont have instances of the function
        static void Main(string[] args)
        {

            // very basic code of variables, printing into console etc ----------------------------------------
            /*
            string name = "Joey Apple";
            int age = 32;
            //float y = 5.4;

            Console.WriteLine("Hello, my friend is " + name + " and his age is " +  age);
            */
            //---------------------------------------------------------------------------------------------------

            // Set applicaiton variables
            GetAppInfo(); // run GetAppInfo function to get the info

            while (true) {

                GetName(); // ASK FOR User name and greet

            // Init correct number
            int correctNumberOld = 7;

            //generate random number within 0-10
            Random random = new Random(); //we set random to the class Random, which has functions attached to it
            int correctNumber = random.Next(1,10); //generate random number from 1-10

            // Init guess var
            int guess = 0;

            // Ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            //whilte guess is not correct
            while (guess !=correctNumber) { 
                // Get users input
                string input = Console.ReadLine();

                // Make sure its a number
                if (!int.TryParse(input, out guess))
                {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red,"Please use an actual number");

                    // Keep going
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if (guess!=correctNumber)
                {

            
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
            }

            //sucess message
            //printing YOU ARE CORRECT MESSAGE, with yellow font color
                PrintColorMessage(ConsoleColor.Yellow, "You are correct! Congratulations!!!");

                //Ask to play again
                Console.WriteLine("Play again? (Y or N)");

             //get answer
             string answer = Console.ReadLine().ToUpper(); // ToUpper changes everything to the upper case

            if(answer == "Y")
                {
                    continue;
                }
            else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.1";
            string appAuthor = "Pavol Lantaj";

                //change text color
                Console.ForegroundColor = ConsoleColor.Green;

                //write out app info
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                //change text color
                Console.ForegroundColor = ConsoleColor.White;
                //OR
                Console.ResetColor();
            }

        //ask user name and greet
        static void GetName()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play the game!", inputName);

        }

        // print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //change text color BACK
            Console.ResetColor();
        }
    }
}
