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

}

public string viewCardMEnu()
{

}

public string MArkCardoffMenu()
{

}



        
}

