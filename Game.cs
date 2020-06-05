using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoCard
{
    public class Game
    {
        //public string playerName;
        public Player player;

        public Game()
        {
            //this.playerName = playerName;
        }

        public void startMenu()
        {
            player = new Player();
            Console.WriteLine("*********************");
            Console.WriteLine("*" + "Welcome to Bingo" + "*");
            Console.WriteLine("*********************");
            Console.WriteLine("Please enter your name ");
            player.Name = Console.ReadLine();

            Console.WriteLine("Welcome " + player.Name + ". Please enter your selection");
            Console.WriteLine("1. Create New Bingo Card");
            Console.WriteLine("2. Exit");

            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 1)
            {
                createCardMenu();
            }
            else if (userinput == 2)
            {
                Console.Write("So you have chosen death....");
                return;
            }
        }

        public void createCardMenu()
        {
            Console.WriteLine("To create your card please enter the size of the board");
            Console.WriteLine("the board size must be a sqaure number for the board to be created");
            Console.WriteLine("For example 2x2 = 4, 3x3 = 9, 4x4 = 16, 5x5 = 25, etc...");
            Console.WriteLine("The actual numbers on the card are seqential from 1 - max number available per card");
            Console.WriteLine("Now please enter your board size");
            int userBoardSize = Convert.ToInt32(Console.ReadLine());
            var truth = isSqr(userBoardSize);

            if (truth)
            {
                Console.WriteLine("Please enter the smallest number in range");
                int minRange = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the largest number in range");
                int maxRange = Convert.ToInt32(Console.ReadLine());

                player.AddCard(userBoardSize, minRange, maxRange);/// here we attch all the data we need for the card to the player
                ShowCardGrid(userBoardSize); //// here the userboard size the user puts in gets passed to the showcard grid method.

                // game has a player member with a card member which has all valid numbers in the range the user has inputted
                Console.WriteLine("Would you like to mark a number off your card or exit? ");
                Console.WriteLine("1. Mark a number off your Bingo Card");
                Console.WriteLine("2. Exit");
                int userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput == 1)
                {
                    MarkCardMenu();
                }
                else if (userinput == 2)
                {
                    Console.Write("So you have chosen death....");
                    return;
                }

            }
            else
            {
                Console.WriteLine("Your number was not a sqaure");//// sort o the error catch and takes them back to the top again.
                createCardMenu();
            }
        }

        public void ShowCardGrid(int gridsize)  // gridsize was 16
        {
            double squareRoot = Math.Sqrt(gridsize);     // 4

            //player.card.cardNums is a list of all the numbers 

            int index = 0;

            for (int y = 0; y < squareRoot; y++)

            {

                bool isFirst = true;

                for (int x = 0; x < squareRoot; x++)
                {
                    if (isFirst == true)
                    {
                        Console.Write("\n" + player.card.CardNums[index]);

                        isFirst = false;
                    }
                    else
                    {       ///// "\t" goes to the next tabspace
                        Console.Write("\t" + player.card.CardNums[index]);
                    }
                    index++;
                }

            }


        }


        public string MarkCardMenu()
        {
            int targetInt = 0;
            Console.WriteLine("Enter your number to mark off ");
            targetInt = Convert.ToInt32(Console.ReadLine());
            
        }

        public int markCard(int usernum){
            var output = 0;
            var x  = player.card.CardNums.Contains(usernum);
            if (x == true){
                player.card.CardNums[player.card.CardNums.FindIndex(ind=>ind.Equals(usernum))] =  Convert.ToInt32("-1");
            }
            else{
                Console.WriteLine("Your number does not exist in the card - please try again");
                MarkCardMenu();
            }
            return output;
        }

        public bool isSqr(int num)
        {
            // get the square root WITH any fractional component 
            double sq1 = Math.Sqrt(num);

            // get square root with fraction truncated by casting as an int
            int sq2 = (int)Math.Sqrt(num);

            // compare the numbers as doubles and see if equal
            // if the fraction part of sq1 was zero (perfect square), then 
            // the int and the double will be equivalent
            if (sq1 == (double)sq2)
                return true;
            return false;

        }

    }

}
