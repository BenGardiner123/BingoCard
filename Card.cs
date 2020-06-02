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

        /* public static Random = new Random(int); */
        


        public Card(int totalNumreqd, int cardMin, int cardMax)
        {

            this.min = cardMin;
            this.max = cardMax;
            this.cardSize = totalNumreqd;


            // ithink i need togenerate alist of random numbers say 1- 1000 andout them imhere everytime a card gets created i can iterate out whatever range is required making sure they dont repeat
            // here we create an instance of a random object - YAKEN FROM MY PREVIOUS C# WORKS
            var rand = new System.Random();
            for (int i = cardMin; i < totalNumreqd + 1; i++)
            {
                // then i need to store the random number in somewhere object.Next(n, n)
                var randCardNum = rand.Next(1, 10000);

            }
        

        }



