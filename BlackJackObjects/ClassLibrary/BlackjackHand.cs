using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class BlackjackHand : Hand
    {
        List<BlackjackCards> Bhand = new List<BlackjackCards>();
        public int Score { get; private set; }

        public bool IsDealer = false;
        
        int aceCount = 0;
        public BlackjackHand()
        {
            IsDealer = false;
            Score = 0;
        }
        public BlackjackHand(bool isDealer) 
        {
            IsDealer = isDealer;
            Score = 0;

        }

        

        override public void AddCard(ICards newCard) //ace logic shold be here
        {
                     
            base.AddCard(newCard);
            BlackjackCards blackjackCards = new BlackjackCards(newCard.Face,newCard.Suit);
            if(blackjackCards.Face == CardFace.ace)
            {
                aceCount++;
            }            
            if (aceCount != 0 && (Score + blackjackCards.value)>21)
            {
                Score -= 10;
                Score += blackjackCards.value;
                aceCount--;
            }
            else
                Score += blackjackCards.value;

        }
        override public void Draw(int x, int y)
        {
            if(IsDealer)
            {
                base.Draw(x, y);
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("   ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if(!IsDealer)
            {
                base.Draw(x, y);
            }
        }
        public void DrawHiddenCard(int x, int y)
        {
            if(IsDealer)
            {
                IsDealer = false;
                Draw(x,y);
            }
        }

    }
}
