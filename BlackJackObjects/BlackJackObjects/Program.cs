using ClassLibrary;
using System;
using System.Text;

namespace BlackJackObjects
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Deck theDeck = new Deck();

            string[] Options = new string[] { "1: Play Blackjack", "2: Shuffle & Show Deck", "3: Exit" };
            int logic = 0;



            while (logic == 0)
            {
                MenuChoice("Choice: ", Options, out int Choice);
                
                switch (Choice)
                {
                    
                    
                    case 0:
                        int Monie = 10000;
                        bool win = false;
                        bool endturn = false;
                        
                        while (!win)
                        {
                            
                            int bet = 0;
                          
                            bet = PlaceBet(Monie);
                            Monie -= bet;
                            
                            
                            Console.Clear();
                            Console.SetCursorPosition(25,0);
                            Colormonie(Monie);
                            Console.SetCursorPosition(0,0);
                            Console.WriteLine("Placed Bet: " + bet+"\n\n");
                            
                            Deck deck = new Deck();
                            deck.Shuffle();
                            BlackjackHand Dhand = new BlackjackHand(true);
                            BlackjackHand Phand = new BlackjackHand();
                            Dhand.AddCard(deck.Deal());
                            int DScore = Dhand.Score;
                            Phand.AddCard(deck.Deal());
                            Dhand.AddCard(deck.Deal());
                            Phand.AddCard(deck.Deal());
                            Dhand.Draw(20, 5);
                            Phand.Draw(20, 10);
                            Console.SetCursorPosition(0, 10);
                            Console.Write("Score: " + Phand.Score);
                            Console.SetCursorPosition(0, 5);
                            
 
                            Console.Write("Score: " + (Dhand.Score- DScore));

                            if (Dhand.Score == 21)
                            {
                                Console.SetCursorPosition(10, 6);
                                Console.WriteLine("Dealer Wins!!!");
                                Console.SetCursorPosition(7, 5);
                                Console.Write(Dhand.Score);
                                Dhand.DrawHiddenCard(20, 5);
                                win = true;
                            }
                            if (Phand.Score == 21)
                            {
                                Console.SetCursorPosition(10, 11);
                                Console.WriteLine("You Win!!!");
                                Dhand.DrawHiddenCard(20, 5);
                                win = true;
                            }
                            
                            string[] playeractions = new string[] { "1: Hit", "2: Stand" };
                            while (!endturn && !win)
                            {
                                MenuChoice2("Choice:", playeractions, out int Pchoice);

                                switch (Pchoice)
                                {
                                    case 0:

                                        Phand.AddCard(deck.Deal());
                                        Phand.Draw(20, 10);
                                        Console.SetCursorPosition(7, 10);
                                        Console.Write(Phand.Score);
                                        if (Phand.Score > 21 )
                                        {
                                            Console.SetCursorPosition(10, 11);
                                            Console.WriteLine("You Busted!!!");
                                            Dhand.DrawHiddenCard(20, 5);
                                            win = true;
                                            endturn = true;
                                           
                                        }
                                        if (Phand.Score == 21)
                                        {
                                            Console.SetCursorPosition(10, 11);
                                            Console.WriteLine("You Win!!!");
                                            Dhand.DrawHiddenCard(20, 5);
                                            Monie += bet;
                                            win = true;
                                            endturn = true;
                                        }

                                        break;
                                    case 1:
                                        endturn = true;
                                        break;

                                }// players turn
                            }
      
                            while (Dhand.Score < 17 && !win)
                            {
                                Dhand.AddCard(deck.Deal());
                                Console.SetCursorPosition(7, 5);
                                Console.Write(Dhand.Score - DScore);
                                Dhand.Draw(20,5);
                                
                                if (Dhand.Score > 21 && !win)
                                {
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("Dealer Busted!!!");
                                    Console.SetCursorPosition(7, 5);
                                    Console.Write(Dhand.Score);
                                    Dhand.DrawHiddenCard(20, 5);
                                    
                                
                                win = true;
                                break;
                                }
                                if (Dhand.Score == 21)
                                {
                                    Console.SetCursorPosition(0, 6);
                                    Console.WriteLine("Dealer Wins!!!");
                                    Console.SetCursorPosition(7, 5);
                                    Console.Write(Dhand.Score);
                                    Dhand.DrawHiddenCard(20, 5);
                                    win = true;
                                }
                            }// Dealers turn
                            
                            if (Dhand.Score > Phand.Score && Dhand.Score <= 21 && !win )
                            {
                                Console.SetCursorPosition(10, 6);
                                Console.WriteLine("Dealer Wins!!!");
                                Console.SetCursorPosition(7, 5);
                                Console.Write(Dhand.Score);
                                Dhand.DrawHiddenCard(20, 5);
                                win = true;
                            }
                            if (Dhand.Score < Phand.Score && Phand.Score <=21 &&!win)
                            {
                                
                                Console.SetCursorPosition(10, 11);
                                Console.WriteLine("You win Wins!!!");
                                Dhand.DrawHiddenCard(20, 5);
                                Monie += bet;
                                win = true;
                            }
                            if (Dhand.Score == Phand.Score && Dhand.Score <= 21 && !win)
                            {
                                Console.SetCursorPosition(7, 5);
                                Console.Write(Dhand.Score);
                                Console.SetCursorPosition(10, 11);
                                Console.WriteLine("Its a tie!!!");
                                Console.SetCursorPosition(10, 6);
                                Console.WriteLine("Its a tie!!!");
                                Dhand.DrawHiddenCard(20,5);
                                win = true;
                            }

                            
                            
                            bool Nopick = true;
                            if (Monie > -100000)
                            {
                                while (Nopick)
                                {
                                    Console.SetCursorPosition(10, 25);
                                    Console.WriteLine("Play Again(y/n)                                    ");
                                    Console.SetCursorPosition(26, 25);
                                    string play = Console.ReadLine();

                                    if (play == "y" || play == "Y")
                                    {
                                        win = false;
                                        Nopick = false;
                                        endturn = false;
                                    }
                                    else if (play == "n" || play == "N")
                                    {
                                        Nopick = false;
                                    }
                                    else if (play != "n" && play != "y" && play != "N" && play != "Y")
                                    {
                                        Console.SetCursorPosition(10, 26);
                                        Console.WriteLine("Invalid input");
                                    }
                                     Monie = IntrestCal(Monie);
                                    
                                }
                            }
                            else
                            {
                                
                                Console.Clear();
                                Console.SetCursorPosition(10,10);
                                Console.WriteLine($"Due to your uncontrolable gambleing your debt of {Monie * -1} will be paid in blood. You will now beeing hunted by the sponsers of our casino.\n\n\n\t\tGoodluck");
                                Console.ReadKey();         
                            }
                            

                        }
                        

                        break;
                    case 1:
                        theDeck.Shuffle();
                        int x = 0;
                        int y = 10;

                        for (int i = 0; i < 52; i++)
                        {

                            ICards card = theDeck.Deal();
                            card.Draw(x, y);
                            x += 4;
                            if (x > 60)
                            {
                                x = 0;
                                y += 2;
                            }


                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        logic++;
                        break;
                }
            }

        }
        private static void MenuChoice(string prompt, string[] options, out int selection)
        {
            #region Menu
            Console.Clear();
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
                Console.WriteLine();
            }
            #endregion

            #region PassByWithOut
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(0,8);
                    Console.Write(prompt);
                    Console.ForegroundColor = ConsoleColor.White;

                    
                    
                    selection = int.Parse(Console.ReadLine()) - 1;
                    if (selection >= 0 && selection >= options.Length)
                    {                        
                        Console.WriteLine("Input is outside of parameters.");
                        
                        Console.ReadKey();
                        
                    }
                    else break;




                }
                catch (Exception oopsies)
                {

                    Console.WriteLine(oopsies.Message);
                    Console.WriteLine();
                    Console.ReadKey();


                }


            } while (true);
            #endregion

        }
        private static void MenuChoice2(string prompt, string[] options, out int selection)
        {
            #region Menu
            Console.SetCursorPosition(0, 20);
            for (int i = 0; i < options.Length; i++)
            {

                Console.WriteLine(options[i]);
                Console.WriteLine();
            }
            #endregion

            #region PassByWithOut
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(prompt);
                    Console.ForegroundColor = ConsoleColor.White;

                    
                    selection = int.Parse(Console.ReadLine()) - 1;
                    if (selection < 0 && selection > options.Length)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Input is outside of parameters.");

                    }
                    else break;




                }
                catch (Exception oopsies)
                {

                    Console.WriteLine(oopsies.Message);
                    Console.WriteLine();
                    Console.ReadKey();


                }


            } while (true);
            #endregion
            
        }
        private static int PlaceBet(int monie)
        {

            int bet = 0;
            bool hasntbet = true;

            while (hasntbet)
            {
                while (bet <= 0)
                {
                    Console.Clear();
                    Console.Write("Place Bet:");
                    Console.SetCursorPosition(25,0);
                    Colormonie(monie);
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("You may bet as much as you want this casino also hands out loans conveniently");
                    Console.SetCursorPosition(11, 0);
                    bool stupidbug = true;
                    try
                    {

                        bet = int.Parse(Console.ReadLine());
                        
                    }
                    catch
                    {
                        Console.WriteLine("Must use a Hole number\n");
                        Console.Write("Press any key to continue...");
                        stupidbug = false;
                        Console.ReadKey();
                    }
                    if (bet <= 0 && stupidbug)
                    {
                        Console.WriteLine("\n\n\nHint: Bet connot be < 0.");
                        Console.ReadKey();
                    }

                }
                hasntbet = false;
            }
            return bet;
        }
        private static void Colormonie(int monie)
        {
            if(monie>=0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(monie);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(monie);
                Console.SetCursorPosition(45, 0);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("3% intrest per round if psitive 20% intrest if negative (Disclamer: This casino rounds to the nearest monie for your conviniace)");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        private static int IntrestCal(int monie)
        {                        

            if (monie < 0)
            {
                    double intrest = (-monie) * .2;
                    monie -= (int)intrest;
            }
                        
            else if (monie > 0)
            {
                double intrest = (monie) * .03;
                monie += (int)intrest;
            }
            return monie;
        }
    }
}
