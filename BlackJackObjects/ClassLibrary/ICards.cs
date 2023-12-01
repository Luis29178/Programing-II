using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface ICards
    {
        CardFace Face { get; }
        CardSuit Suit { get; }       
        void Draw(int x, int y);

    }



}
