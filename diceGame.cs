using System;

namespace diceGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int gameCounter = 0;//Initiate the number of games
            string answer = "";//User input placeholder
            
            Random rnd = new Random();//New random class
            Console.WriteLine("Hey! Welcome to Tina's Dice Game." +
                               "\nLet's start!");//Print the intro of the game 
            while (true)//looping the code 
            {
                gameCounter++;//counting how many times the game is playing
                int dice1 = rnd.Next(1, 7);//random number for Dice 1
                int dice2 = rnd.Next(1, 7);//random number for Dice 2
                int diceTotal = dice1 + dice2;//adding both of the random numbers together

                if (diceTotal % 2 == 0)//checking if the total is an even number 
                {
                    Console.WriteLine("I got " + dice1 + " and " + dice2 + "!");//printing Dice 1 and Dice 2
                    Console.WriteLine("Evens are better than odds!");//message that the sum of both Dices is an even number
                }
                else//checking if the total is an odd number
                {
                    Console.WriteLine("I got " + dice1 + " and " + dice2 + "!");//printing Dice 1 and Dice 2 
                    Console.WriteLine("Odds are still cool!");//message that the sum of both Dices is an odd number
                }

                Console.WriteLine(" Do you want to play again? ");//Asking the user if (he/she) want to play again
                answer = Console.ReadLine();//user response
                string userInput = answer.ToUpper();

                if (userInput == "YES")//the user said YES(case-sensitive)
                {
                    continue;//repeating the game one more time
                }
                else//user enter anytihing but YES(case-sensitive)
                {
                    Console.WriteLine("The number of times the dice was thrown is: " + gameCounter);//printing how many times the user played the game
                    Console.WriteLine("Nice Game!");//printing a fun message 
                    Console.WriteLine("Thanks for playing, Come play again soon!");//printing thank message
                    break;//Ending the game  
                }

            }
        }
    }
}
