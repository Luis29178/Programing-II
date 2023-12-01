using System;
using System.Collections.Generic;
using System.IO;

namespace Sorting
{
    public class Program
    {




        static void Main(string[] args)
        {
            string[] Menue = new string[] { "1. Bubble Sort", "2. MergeSort", "3. Bianary Serch", "4.  Exit" };
            List<string> Unsortedtitles = new List<string>(GetTitles().Split(','));
            bool TheMagic = true;


            while (TheMagic)
            {
                List<string> BSorted = new List<string>(GetTitles().Split(','));
                List<string> MSorted = new List<string>(GetTitles().Split(','));
                int ypos = 9;
                int xpos = 0;
                Console.Clear();
                MenuChoice("Chice: ", Menue, out int Choice);
                switch (Choice)
                {
                    case 0://Bubble Sort
                        #region BubleSort

                        Console.WriteLine("----------------------------------------------------------------------------------------Bouble Sorted---------------------------------------------------------------------------------");
                        BubbleSort(BSorted);
                        foreach (string item in Unsortedtitles)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, ypos);
                            Console.WriteLine(item);
                            ypos++;
                        }                        
                        ypos = 9;
                        foreach (string item in BSorted)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(50, ypos);
                            Console.WriteLine(item);
                            ypos++;
                          
                        }





                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(0, 95);
                        Console.Write("Press Any Key to Return...");
                        Console.ReadKey();
 

                        #endregion
                        break;

                    case 1://MergeSort
                        #region Merge Sort
                        Console.WriteLine("----------------------------------------Merge Sorted----------------------------------------");
                        List<string> msorted = new List<string>(MergeSort(MSorted));
                        foreach (string item in Unsortedtitles)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, ypos);
                            Console.WriteLine(item);
                            ypos++;
                        }
                        ypos = 9;
                        foreach (string item in msorted)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(50, ypos);
                            Console.WriteLine(item);
                            ypos++;

                        }
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(0, 95);
                        Console.Write("Press Any Key to Return...");
                        Console.ReadKey();
                        #endregion
                        break;

                    case 2://Bianary search
                        #region BianarySerch
                        Console.WriteLine("----------------------------------------------------------Bianary Serch------------------------------------------------");
                        BubbleSort(BSorted);

                        foreach (string item in BSorted)
                        {
                            int Index = BianarySerch(BSorted, item, 0, BSorted.Count);
                            Console.SetCursorPosition(xpos, ypos);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(item);
                            xpos += 45;
                            Console.SetCursorPosition(xpos, ypos);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write($"Index: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{BSorted.IndexOf(item)}");
                            xpos += 15;
                            Console.SetCursorPosition(xpos, ypos);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write($"Found Index: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{Index}");
                            xpos = 0;
                            ypos++;

                        }


                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(0, 95);
                        Console.Write("Press Any Key to Return...");
                        Console.ReadKey();


                        #endregion
                        break;

                    case 3:
                        TheMagic = false;
                        break;
                }
            }





        }
        private static string GetTitles()
        {
            string file = @"inputFile.csv";
            using (StreamReader sr = new StreamReader(file))
            {
                string txt = sr.ReadToEnd();
                return txt;
            }

        }
        private static List<string> BubbleSort(List<string> items)
        {

            List<string> _items = new List<string>();
            _items = items;

            int n = _items.Count;
            bool swapped = true;
            do
            {
                swapped = false;
                for (int j = 1; j < n; j++)
                {
                    if (_items[j - 1].CompareTo(_items[j]) > 0)
                    {
                        string temp = _items[j - 1];
                        _items[j - 1] = _items[j];
                        _items[j] = temp;
                        swapped = true;
                    }

                }
                n--;
            } while (swapped);

            return _items;
        }

        private static int BianarySerch(List<string> _titles, string Serched, int min, int max)
        {

            if (max >= min)
            {
                int mid = min + (max - min) / 2;
                if (_titles[mid].CompareTo(Serched) == 0 && _titles[mid] == Serched)
                {
                    return mid;
                }
                if (_titles[mid].CompareTo(Serched) > 0)
                {
                    return BianarySerch(_titles, Serched, min, mid - 1);
                }
                if (_titles[mid].CompareTo(Serched) < 0)
                {
                    return BianarySerch(_titles, Serched, mid + 1, max);
                }

            }
            return -1;


        }

        private static List<string> MergeSort(List<string> items)
        {
            List<string> titles = new List<string>(items);

            if (items.Count <= 1)
                return titles;

            List<string> left = new List<string>();
            List<string> right = new List<string>();
            int index = 0;

            foreach (string item in titles)
            {
                if (index < (titles.Count / 2))
                {
                    left.Add(titles[index]);
                }
                else
                {
                    right.Add(titles[index]);
                }
                index++;

            }
            left = MergeSort(left);
            right = MergeSort(right);
            titles = Merge(left, right);
            return titles;


        }
        private static List<string> Merge(List<string> LeftValues, List<string> RightValues)
        {
            List<string> result = new List<string>();
            while (LeftValues.Count != 0 || RightValues.Count != 0)
            {
                try
                {
                    if (LeftValues[0].CompareTo(RightValues[0]) <= 0)
                    {
                        result.Add(LeftValues[0]);
                        LeftValues.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(RightValues[0]);
                        RightValues.RemoveAt(0);
                    }
                }
                catch
                {
                    while (LeftValues.Count != 0)
                    {
                        result.Add(LeftValues[0]);
                        LeftValues.RemoveAt(0);
                    }
                    while (RightValues.Count != 0)
                    {
                        result.Add(RightValues[0]);
                        RightValues.RemoveAt(0);
                    }
                }
            }



            return result;
        }

        private static void MenuChoice(string prompt, string[] options, out int selection)
        {
            foreach (string item in options)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(item);
            }

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(prompt);
                    selection = int.Parse(Console.ReadLine()) - 1;
                    if (selection < 0 && selection > options.Length)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Input is outside of parameters.");

                    }
                    else break;

                }
                catch (Exception CanYouRead)
                {
                    Console.WriteLine($"Can you read ?!   {CanYouRead}");
                }

            } while (true);


        }
    }

}
