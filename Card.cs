using System;
using System.Collections.Generic;
using System.Linq;
namespace BingoCard
{
    public class Card
    {
        public int min;
        public int max;
        public List<int> CardNums;
        public int cardSize;
        Random rand = new System.Random();

        public Card(int totalNumreqd, int cardMin, int cardMax)
        {
            //totalNumReqd 25, cardmin 1, cardmax 100
            this.min = cardMin;
            this.max = cardMax;
            this.cardSize = totalNumreqd;
            this.CardNums = new List<int>();

            // ithink i need togenerate alist of random numbers say 1- 1000 andout them imhere everytime a card gets created i can iterate out whatever range is required making sure they dont repeat
            // here we create an instance of a random object - tAKEN FROM MY PREVIOUS C# WORKS

            for (int i = cardMin; i < totalNumreqd + 1; i++)
            {               
                bool validNumber = false; // initialise escape variable 
                var randCardNum = rand.Next(1, cardMax); // generate random number

                while (validNumber == false) // check if number is valid
                {                    
                    if (!CardNums.Contains(randCardNum))  // check if number is not in list
                    {
                        validNumber = true; // not in list, hence we can update the validNumber to true so the loop won't runa gain
                    }
                    else
                    {
                        randCardNum = rand.Next(1, cardMax); // otherwise regenerate a new random number
                    }
                }

                CardNums.Add(randCardNum);
            }
        }      
    }
}





