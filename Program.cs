using System;
using System.Collections.Generic;

namespace BingoCard
{
    class Program
            {
                static void Main(string[] args)
                {
        

                    List<Card> PlayerCard = new List<Card>(25);
                    Player p1 = new Player("Ben Gardiner", PlayerCard);

                    System.Console.WriteLine(p1.Name);
                    System.Console.WriteLine(p1.PlayerCard);
                    
                    Console.WriteLine("Welcome to Bingo");
                    Console.WriteLine("Please enter your name ");
                    Console.WriteLine("Please enter your selcection");
                    Console.WriteLine("1. Create New Bingo Card");
                    Console.WriteLine("2. Exit");
                    ///insert menu check here
                    var userinput = 1; Convert.ToInt32(Console.ReadLine());  
                    if (userinput == 1)
                    {
                        g1.addCard(1);
                    }
                    else if (userinput == 2) 
                    {
                        Console.Write("You have not entered a number. . .Goodbye");
                        return;
                    } 

                    //then go to card creation
                    Console.WriteLine("To create your card please enter the size of the board");
                    Console.WriteLine("the board size must be a sqaure number for the board to be created");
                    Console.WriteLine("For example 2x2 = 4, 3x3 = 9, 4x4 = 16, 5x5 = 25, etc...");
                    Console.WriteLine("The actual numbers on the card are seqential from 1 - max number available per card");
                    Console.WriteLine("Now please enter your board size");
                    int userBoardSize = Convert.ToInt32(Console.ReadLine());  
                    var truth = Game.isSqr(userBoardSize);
                    
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
            }    


}
