using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoCard
{
    public class Game
    {
        private readonly string playerName;

        // attributes

        ////..................------------....-----------........ CONSTRUCTOR.....
        public Game(string playerName)
        {
            this.playerName = playerName;
        }


        // methods ----------------------------------------------------------------

        public string startMenu()
        {

            Console.WriteLine("Welcome to Bingo");
            Console.WriteLine("Please enter your name ");
            Console.WriteLine("Please enter your selcection");
            Console.WriteLine("1. Create New Bingo Card");
            Console.WriteLine("2. Exit");
            ///insert menu check here
            var userinput = 1; Convert.ToInt32(Console.ReadLine());
            if (userinput == 1)
            {
                createCardMenu();
            }
            else if (userinput == 2)
            {
                Console.Write("You have not entered a number. . .Goodbye");
                startMenu();
            }


            public string createCardMenu()
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

                }
                else
                {
                    Console.WriteLine("Your number was not a sqaure");
                    startMenu();

                }

            }

            public string viewCardMEnu()
            {

            }

            public string MArkCardoffMenu()
            {

            }
            static bool isSqr(int num)
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

