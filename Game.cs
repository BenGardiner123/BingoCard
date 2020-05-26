using System.Collections.Generic;
using System.Linq;

namespace BingoCard
{
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