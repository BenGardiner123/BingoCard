using System.Collections.Generic;
using System.Linq;
namespace BingoCard
{
    public class Card {
            public  int min;
            public int max;
            public List<int> CardNums;
            public int randCardNum;
    

            public Card( int cardMin, int cardMax){
               
                this.min = cardMin;
                this.max = cardMax;
                
            /// List<int> lists = Enumerable.Range(1, CardSize).ToList(); // not sure if i need thsi yet - just a placeholder in case

            // ithink i need togenerate alist of random numbers say 1- 1000 andout them imhere everytime a card gets created i can iterate out whatever range is required making sure they dont repeat
            // here we create an instance of a random object - YAKEN FROM MY PREVIOUS C# WORKS


            var rand = new System.Random();
            // then i need to store the random number in somewhere object.Next(n, n)
            int randCardNum = rand.Next(1, 10000);

            IList<int> numbers = new List<int>();
            for (int i = 0; i < cardMax; i++)
            {
                


            }

            }
    

            


}
