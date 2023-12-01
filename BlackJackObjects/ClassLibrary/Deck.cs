using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Deck 
    {
        readonly List<ICards> _cards = new List<ICards>();
        private int DeckPosition = 51;
        public Deck() 
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    _cards.Add(Factory.CreateBlackjackCard((CardFace)j,(CardSuit)i));
                }
            }         

        }

        public ICards Deal()
        {
            ICards tcard = _cards[DeckPosition];
            if (DeckPosition == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        _cards.Add(Factory.CreateBlackjackCard((CardFace)j, (CardSuit)i));
                    }
                }
                
                DeckPosition = 51;
                return tcard;
            }
            else
            {                
                DeckPosition--;
                return tcard;
            }
        }
        public void Shuffle()
        {
            Random rng = new Random();

            for(int i = 0; i < _cards.Count*2; i++)
            {
                int max = _cards.Count;
                int random = rng.Next(0,max-1);
                ICards cards = _cards[random];
                _cards[random] = _cards[max-1];
                _cards[max-1] = cards;

            }
              
        }
        

    }
}
