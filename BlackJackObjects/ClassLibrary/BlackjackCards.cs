using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class BlackjackCards : Cards
    {
        
        public int value { get; }

        public BlackjackCards(CardFace Face, CardSuit Suit) : base(Face,Suit)
        {
            if(Suit == CardSuit.Spades)
            {
                if (Face == CardFace.ace)
                {
                    value = 11;
                }
                if (Face == CardFace.two)
                {
                    value = 2;
                }
                if (Face == CardFace.three)
                {
                    value = 3;
                }
                if (Face == CardFace.four)
                {
                    value = 4;
                }
                if (Face == CardFace.five)
                {
                    value = 5;
                }
                if (Face == CardFace.six)
                {
                    value = 6;
                }
                if (Face == CardFace.seve)
                {
                    value = 7;
                }
                if (Face == CardFace.eight)
                {
                    value = 8;
                }
                if (Face == CardFace.nine)
                {
                    value = 9;
                }
                if (Face == CardFace.ten)
                {
                    value = 10;
                }
                if (Face == CardFace.jack)
                {
                    value = 10;
                }
                if (Face == CardFace.qween)
                {
                    value = 10;
                }
                if (Face == CardFace.king)
                {
                    value = 10;
                }

            }
            if (Suit == CardSuit.Clubs)
            {
                if (Face == CardFace.ace)
                {
                    value = 11;
                }
                if (Face == CardFace.two)
                {
                    value = 2;
                }
                if (Face == CardFace.three)
                {
                    value = 3;
                }
                if (Face == CardFace.four)
                {
                    value = 4;
                }
                if (Face == CardFace.five)
                {
                    value = 5;
                }
                if (Face == CardFace.six)
                {
                    value = 6;
                }
                if (Face == CardFace.seve)
                {
                    value = 7;
                }
                if (Face == CardFace.eight)
                {
                    value = 8;
                }
                if (Face == CardFace.nine)
                {
                    value = 9;
                }
                if (Face == CardFace.ten)
                {
                    value = 10;
                }
                if (Face == CardFace.jack)
                {
                    value = 10;
                }
                if (Face == CardFace.qween)
                {
                    value = 10;
                }
                if (Face == CardFace.king)
                {
                    value = 10;
                }
            }
            if (Suit == CardSuit.Hearts)
            {
                if (Face == CardFace.ace)
                {
                    value = 11;
                }
                if (Face == CardFace.two)
                {
                    value = 2;
                }
                if (Face == CardFace.three)
                {
                    value = 3;
                }
                if (Face == CardFace.four)
                {
                    value = 4;
                }
                if (Face == CardFace.five)
                {
                    value = 5;
                }
                if (Face == CardFace.six)
                {
                    value = 6;
                }
                if (Face == CardFace.seve)
                {
                    value = 7;
                }
                if (Face == CardFace.eight)
                {
                    value = 8;
                }
                if (Face == CardFace.nine)
                {
                    value = 9;
                }
                if (Face == CardFace.ten)
                {
                    value = 10;
                }
                if (Face == CardFace.jack)
                {
                    value = 10;
                }
                if (Face == CardFace.qween)
                {
                    value = 10;
                }
                if (Face == CardFace.king)
                {
                    value = 10;
                }
            }
            if (Suit == CardSuit.Diamonds)
            {
                if (Face == CardFace.ace)
                {
                    value = 11;
                }
                if (Face == CardFace.two)
                {
                    value = 2;
                }
                if (Face == CardFace.three)
                {
                    value = 3;
                }
                if (Face == CardFace.four)
                {
                    value = 4;
                }
                if (Face == CardFace.five)
                {
                    value = 5;
                }
                if (Face == CardFace.six)
                {
                    value = 6;
                }
                if (Face == CardFace.seve)
                {
                    value = 7;
                }
                if (Face == CardFace.eight)
                {
                    value = 8;
                }
                if (Face == CardFace.nine)
                {
                    value = 9;
                }
                if (Face == CardFace.ten)
                {
                    value = 10;
                }
                if (Face == CardFace.jack)
                {
                    value = 10;
                }
                if (Face == CardFace.qween)
                {
                    value = 10;
                }
                if (Face == CardFace.king)
                {
                    value = 10;
                }
            }        
        }
       
    }

}
 