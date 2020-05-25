using System;
using System.Collections.Generic;

namespace BingoCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c1  = new Card();
            Console.WriteLine("Welcome to Bingo");
            Console.WriteLine("Please enter your name ");
            Console.WriteLine("Please enter your selcection");
            Console.WriteLine("1. Create New Bingo Card");
            Console.WriteLine("2. Exit");
            
            Console.WriteLine("To creeate your game please enter the size of the board");
            Console.WriteLine("the board size must be a sqaure number for the board to be created");
            Console.WriteLine("For example 4, 9, 16, 25, etc...");
            Console.WriteLine("The actual numbers on the card are seqential from 1 - max");
            Console.WriteLine("Now please enter your board size");



        }

        
    }

    public class Menu {

        ///im not sure what the attributes of menu are yet

            
    ///======================== constructor

        public Menu()
        {
           
        }

        public string startMenu()
        {
           
        }

        public string NewGameMenu() 
        {
            Console.WriteLine("To creeate your game please enter the size of the board");C
            Console.WriteLine("the board size must be a sqaure number for the board to be created");
            Console.WriteLine("For example 4, 9, 16, 25, etc...");
            Console.WriteLine("The actual numbers on the card are seqential from 1 - max");
            Console.WriteLine("Now please enter your board size");
            string v = Console.ReadLine();
            

        }
    }

    public class Card {

        public int min;
        public int max;
        
        public List<Card> gameSize; 


        /// something for the grid framework herer


        public Card()
        {

        }

        public int Card(int intmin, int intmax)
        {
           this.min = intmin;
           this.max = intmax;
           

            ///create a board
            
        }

        
    }
     class Player{


            // attributes
            string playerName

            // constructor

            // functions

        }

        class Game {
            // attributes
            int numPlayers;
            int numCards;

            int boardSize;

        public Game(int numPlayers, int numCards, int boardSize)
        {
            this.numPlayers = numPlayers;
            this.numCards = numCards;
            this.boardSize = boardSize;
        }


        // constructor

        // functions
    }


}


/* var userinput = Console.ReadLine();
            int menuCheck;
            bool correctInput = int.TryParse(userinput, out menuCheck);
            if (correctInput)
            {
                Menu();
            }
            else 
            {
                Console.Write("You have not entered a number. . .Goodbye");
            }
 */