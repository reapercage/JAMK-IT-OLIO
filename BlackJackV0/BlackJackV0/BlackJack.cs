using System;
using Veikkaus;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
  class BlackJack
  {
    static void Main()
    {

            Veikkaus.Lotto.DrawLotto();

            //mustajaska();

        }
        
        static void mustajaska()
        {

            int myNumber = 17;
            int theirNumber = 1;
            string inputNumber;
            bool exitTruth = false;
            System.Console.WriteLine("*** BlackJack! ***");

            while (exitTruth == false)
            {
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                //checks if player wants to exit
                inputNumber = System.Console.ReadLine();
                if (inputNumber == "x" || inputNumber == "X" || inputNumber == "exit" || inputNumber == "EXIT")
                {
                    exitTruth = true;
                }
                else
                {
                    theirNumber = System.Convert.ToInt32(inputNumber);
                    if (theirNumber < 1 || theirNumber > 21)
                    {
                        Console.WriteLine("The given number is out of limits, try again.");
                    }
                    else
                    {
                        //comparing
                        if (theirNumber >= myNumber && theirNumber <= 21)
                        {
                            System.Console.WriteLine("You win.");
                        }
                        else
                        {
                            System.Console.WriteLine("You lose.");
                        }
                    }
                }
                //old code
                //theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
                //comparing that given umber is valid

            } //while
            System.Console.WriteLine("Exit");
            Console.ReadLine();

        }
  }
}