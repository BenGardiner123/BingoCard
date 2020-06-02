using System;
using System.Collections.Generic;

namespace BingoCard
{
    public class Player
    {
        ////so this player is just a container for the lst of cards 
        public string Name;
        public Card card;
        public Player()
        {
            //this.Name = playerName;
            //this.playerCard = card;
        }

        public void AddCard(int boardSize, int minrange, int maxrange)
        {
            card = new Card(boardSize, minrange, maxrange);
        }
    }
} 
