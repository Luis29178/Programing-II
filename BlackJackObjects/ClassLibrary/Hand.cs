using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Hand 
    {
        protected List<ICards> _cards = new List<ICards>();



        virtual public void AddCard(ICards newCard)
        {
            _cards.Add(newCard);
        }

        virtual public void Draw(int x, int y)
        {
            
            foreach (ICards item in _cards)
            {
                item.Draw(x,y);
                x += 4;
            }
        }
    }
}
