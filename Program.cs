using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoCard
{
    class Program
    {
        static void Main(string[] args)
        {
            var g1 = new Game(1, 1);
            ///g1.addCard
            var m1 = new Menu(); 

           
           
           
            Console.WriteLine("Welcome to Bingo");
            Console.WriteLine("Please enter your name ");
            Console.WriteLine("Please enter your selcection");
            Console.WriteLine("1. Create New Bingo Card");
            Console.WriteLine("2. Exit");
            ///insert menu check here
            var userinput = 1; /* Convert.ToInt32(Console.ReadLine()); */
            if (userinput == 1)
            {
                g1.addCard(1);
            }
            else if (userinput == 2) 
            {
                Console.Write("You have not entered a number. . .Goodbye");
                return;
            }


            ///then go to card creation
            Console.WriteLine("To create your card please enter the size of the board");
            Console.WriteLine("the board size must be a sqaure number for the board to be created");
            Console.WriteLine("For example 2x2 = 4, 3x3 = 9, 4x4 = 16, 5x5 = 25, etc...");
            Console.WriteLine("The actual numbers on the card are seqential from 1 - max number available per card");
            Console.WriteLine("Now please enter your board size");
            int userBoardSize = Convert.ToInt32(Console.ReadLine());  
            var truth = Menu.isSqr(userBoardSize);
            
            if (truth)
            {
                g1.addCard(userBoardSize);
            }
            else 
            {
                Console.WriteLine("Your number was not a sqaure");
                return;
                ///need to figure out how to make this reuturn to the top menu

            }

            

    }


        

        public class Menu {

            public Menu()
            {
            }

            public static bool isSqr(int num)
            {
            // get the square root WITH any fractional component 
            double sq1 = Math.Sqrt( num );
                
            // get square root with fraction truncated by casting as an int
            int sq2 = (int)Math.Sqrt( num );
                
            // compare the numbers as doubles and see if equal
            // if the fraction part of sq1 was zero (perfect square), then 
            // the int and the double will be equivalent
            if ( sq1 == (double)sq2 )
                return true;
            return false;
            

            }

        } 

    
        public class Game {
        // attributes
            public   int gameNum;
            public   int numCards;

            public List<int> newCard;

            ////..................------------....-----------........ CONSTRUCTOR.....
            public Game(int gnum, int ncard)
            {
                this.gameNum = gnum;
                this.numCards = ncard;
                this.newCard = new List<int>();
            }


            // functions ----------------------------------------------------------------

            public List<int> addCard(int size)
            {
                
                var Card = new List<int>();
                List<int> lists = Enumerable.Range(1, size).ToList();
                Card = lists;
                return lists;


            }

        


        }

    } 

    
    public class Player {
        public string Name;
        public List<Card> PlayerCard;

        public int markBingoNum(int num){
            return 0;  //// this is when the player sleects a number to check off the bingo card
        }


    }

    
    public class Card {
        public int CardSize;
        
        public Card(int CardSize){
            this.CardSize = CardSize;
        }

        public int drawCard(){
            return 0;
        }


    }







}

public class Card {
    public int CardSize;
    
    public Card(int CardSize){
        this.CardSize = CardSize;
    }

    public int drawCard(){
        return 0;
    }


}