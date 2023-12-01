using System;


namespace ClassLibrary
{
    public class Cards : ICards
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }
        
        public void Draw(int x, int y)
        {


                if (Suit == CardSuit.Spades)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    if (Face == CardFace.ace)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("A♠");

                    }
                    if (Face == CardFace.two)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("2♠");
                    }
                    if (Face == CardFace.three)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("3♠");
                    }
                    if (Face == CardFace.four)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("4♠");
                    }
                    if (Face == CardFace.five)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("5♠");
                    }
                    if (Face == CardFace.six)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("6♠");

                    }
                    if (Face == CardFace.seve)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("7♠");
                    }
                    if (Face == CardFace.eight)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("8♠");
                    }
                    if (Face == CardFace.nine)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("9♠");
                    }
                    if (Face == CardFace.ten)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("10♠");
                    }
                    if (Face == CardFace.jack)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("J♠");
                    }
                    if (Face == CardFace.qween)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"Q♠");

                    }
                    if (Face == CardFace.king)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"K♠");

                    }

                }
                if (Suit == CardSuit.Clubs)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    if (Face == CardFace.ace)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"A♣");

                    }
                    if (Face == CardFace.two)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"2♣");
                    }
                    if (Face == CardFace.three)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"3♣");
                    }
                    if (Face == CardFace.four)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"4♣");
                    }
                    if (Face == CardFace.five)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"5♣");
                    }
                    if (Face == CardFace.six)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"6♣");
                    }
                    if (Face == CardFace.seve)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"7♣");
                    }
                    if (Face == CardFace.eight)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"8♣");
                    }
                    if (Face == CardFace.nine)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"9♣");
                    }
                    if (Face == CardFace.ten)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"10♣");
                    }
                    if (Face == CardFace.jack)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"J♣");
                    }
                    if (Face == CardFace.qween)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"Q♣");
                    }
                    if (Face == CardFace.king)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"K♣");
                    }

                }
                if (Suit == CardSuit.Hearts)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    if (Face == CardFace.ace)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"A♥");

                    }
                    if (Face == CardFace.two)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"2♥");

                    }
                    if (Face == CardFace.three)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"3♥");

                    }
                    if (Face == CardFace.four)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"4♥");

                    }
                    if (Face == CardFace.five)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"5♥");

                    }
                    if (Face == CardFace.six)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"6♥");

                    }
                    if (Face == CardFace.seve)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"7♥");

                    }
                    if (Face == CardFace.eight)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"8♥");

                    }
                    if (Face == CardFace.nine)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"9♥");

                    }
                    if (Face == CardFace.ten)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"10♥");

                    }
                    if (Face == CardFace.jack)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"J♥");

                    }
                    if (Face == CardFace.qween)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"Q♥");

                    }
                    if (Face == CardFace.king)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"K♥");

                    }

                }
                if (Suit == CardSuit.Diamonds)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;

                    if (Face == CardFace.ace)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"A♦");

                    }
                    if (Face == CardFace.two)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"2♦");

                    }
                    if (Face == CardFace.three)
                    {
                        Console.SetCursorPosition(x, y);

                        Console.WriteLine($"3♦");
                    }
                    if (Face == CardFace.four)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"4♦");

                    }
                    if (Face == CardFace.five)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"5♦");

                    }
                    if (Face == CardFace.six)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"6♦");

                    }
                    if (Face == CardFace.seve)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"7♦");

                    }
                    if (Face == CardFace.eight)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"8♦");

                    }
                    if (Face == CardFace.nine)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"9♦");

                    }
                    if (Face == CardFace.ten)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"10♦");

                    }
                    if (Face == CardFace.jack)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"J♦");

                    }
                    if (Face == CardFace.qween)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"Q♦");

                    }
                    if (Face == CardFace.king)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"K♦");

                    }

                }
                if (Suit == CardSuit.Blank)
                {
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"   ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;



        }
        public Cards(CardFace face,CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }
    }
 
    public enum CardSuit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds,
        Blank
    }
    public enum CardFace
    {
        ace,
        two,
        three,
        four,
        five,
        six,
        seve,
        eight,
        nine,
        ten,
        jack,
        qween,
        king
    }

}
