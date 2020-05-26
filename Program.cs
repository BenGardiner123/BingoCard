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
            double userBoardSize = Convert.ToInt32(Console.ReadLine()); 
            /// need tocheckhere if the number is a perfect sqaure 
            ///https://jbwyatt.com/Code/Csharp/code/IsPerfect.html something like this - not sure where to put it tho

            if (isSqr(userBoardSize))
            {
                g1.addCard(1);
            }
            else if (userinput == 2) 
            {
                Console.Write("You have not entered a number. . .Goodbye");
                return;
            }

        
        
        
        
     
        
    }

     public class Menu {


        public Menu()
        {
           
        }

       
    } 

    
       public class Game {
            // attributes
         public   int gameNum;
         public   int numCards;

         public List<int> newCard;

        ////..................------------....-----------........ CONSTRUCTOR.....
        public Game(int gameNum, int numCards)
        {
            this.gameNum = gameNum;
            this.numCards = numCards;
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