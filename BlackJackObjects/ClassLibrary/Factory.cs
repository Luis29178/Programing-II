using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class Factory 
    {
         public static ICards CreateCard(CardFace face, CardSuit suit)
        {
            Cards card = new Cards(face,suit);
            return card;
        }
        public static ICards CreateBlackjackCard(CardFace face, CardSuit suit)
        {
            BlackjackCards card = new BlackjackCards(face,suit);            
            return card;
        }
    }
}
