using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Speach method exicution
            char[] splitFactor = new char[] { ' ', '.', ',','!','?','\r','\n' };
            List<string> words = new List<string>(GetSpeachFromFile().ToLower().Split(splitFactor, StringSplitOptions.RemoveEmptyEntries));                      
            Dictionary<string, int> WordAcc = new Dictionary<string, int>();            
            List<string> wordp = new List<string>();  

            
            for (int i = 0; i < words.Count; i++)
            {
                #region ContainsKey Method
                if (!WordAcc.ContainsKey(words[i].ToLower()))
                {
                    WordAcc.Add(words[i].ToLower(), 1);
                    if (!wordp.Contains(words[i]))
                    {
                        wordp.Add(words[i]);
                    }
                    
                }
                else
                {
                    WordAcc[words[i].ToLower()] += 1;
                }
                #endregion

            }
            #endregion

            #region Menu Loop
            int Choice = 0;
            int MenuLogic = 0;
            string[] selct = new string[] { "1: Show Histogram", "2: Search for Word", "3: Save Histogram", "4: Load Histogram", "5: Remove Word", "6: Exit" };

            while (MenuLogic == 0)
            {
                

                ReadChoice("Choice: ", selct, out Choice);
                

                switch (Choice)
                {
                    case 0://Show Histogram                        
                        for (int i = 0; i < wordp.Count; i++) 
                        {
                            Console.Write($"{wordp[i] , 20} ");
                            
                            for(int j = 0; j <= WordAcc[wordp[i].ToLower()]; j++)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.Write($" ");
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            Console.WriteLine($" {WordAcc[wordp[i].ToLower()]}");

                            

                            
                        }
                        Console.WriteLine();
                        Console.Write("Press any key to return...");                        
                        Console.ReadKey();                            
                        break;
                    case 1://Sherch for Word                        
                        do
                        {

                            Console.Write("\nSerch Word: ");
                            string wordsrch = Console.ReadLine();

                            if (WordAcc.ContainsKey(wordsrch.ToLower()))
                            {
                                
                                Console.Write($"{wordsrch} ");
                                for (int j = 0; j <= WordAcc[wordsrch.ToLower()]; j++)
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write(" ");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                }
                                Console.WriteLine($" {WordAcc[wordsrch.ToLower()]}");
                                Console.WriteLine($"\n\n\n{SentanceSerch(wordsrch.ToLower())}");
                                Console.Write("\n\n\n\nPress any key to return...");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"\n{wordsrch} was not found.");
                                Console.Write($"\n\nPress any key to try again...");
                                Console.WriteLine();
                                Console.ReadKey();
                               

                            }
                        } while (true);
                        break;
                    case 2://Save Histogram
                        Console.Write("File Name: ");
                        JsonSer(WordAcc, wordp, splitFactor[2]);                        
                        break;
                    case 3://Load Histogram                        
                        string[] Histogramy = JsonDser(splitFactor[2]);
                        WordAcc.Clear();
                        wordp.Clear();
                        for(int i = 0; i < Histogramy.Length-1; i+= 2)
                        {
                            if (!WordAcc.ContainsKey(Histogramy[i].ToLower()))
                            {
                                string count = Histogramy[i+1];
                                int cout = int.Parse(count);
                                WordAcc.Add(Histogramy[i], cout);
                                wordp.Add(Histogramy[i]);
             
                            }
                            else
                            {
                                WordAcc[words[i].ToLower()] += 1;
                            }

                        }

                        break;
                    case 4://Remove Word
                        RemoveWord(WordAcc,wordp);                        
                        break;
                    case 5://Exit
                        MenuLogic++;
                        break;

                }
                
                
            }

            #endregion


        }
        #region Methods
        private static int ReadInteger(string prompt, int min, int max)
        {
            #region Console Output
            Console.Write(prompt);
            #endregion

            #region Parse

            do
            {
                try
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x < min || x > max)
                    {
                        Console.Clear();
                        Console.WriteLine("Input is outside of parameters.");
                        Console.Write("Press Any Key to try again...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write(prompt);
                        x = int.Parse(Console.ReadLine());
                    }
                    else return x;



                }
                catch (Exception oopsies)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid try again.");
                    Console.WriteLine(oopsies.Message);
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write(prompt + " ");
                }

            } while (true);

            #endregion

        }
        private static void ReadString(string prompt, ref string value)
        {
            Console.Clear();

            #region PassByRef

            string X = value;
            int check = 0;
            do
            {
                if (X != "" && check > 0)
                {                    
                    Console.Write(prompt + X);                    
                    break;
                }
                else if (X == "" && check > 0)
                {                  
                    Console.WriteLine("Please provide an input.");
                    Console.Write(prompt);
                    X = Console.ReadLine();                                                            
                    
                } 
                else if (check <= 0)
                {
                    check++;
                    Console.Write(prompt);
                    X = Console.ReadLine();

                }
            } while (true);

            #endregion            
        }
        private static void ReadChoice(string prompt, string[] options, out int selection)
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
                    Console.Write(prompt);
                    
                    selection = int.Parse(Console.ReadLine()) - 1;
                    if (selection < 0 || selection > options.Length)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Input is outside of parameters.");

                    }
                    else break;

                   


                }
                catch (Exception oopsies)
                {
                    
                    Console.WriteLine("Invalid try again.");
                    Console.WriteLine(oopsies.Message);
                    Console.WriteLine();

                }


            } while (true);
            #endregion







        }
        private static string GetSpeech()
        {
            
            string text = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
           "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
           "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
           "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
           "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
           "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
           "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
           "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
           "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
           "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
           "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
           "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
           "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
           "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";

            return text;

            
        }
        private static string SentanceSerch(string x)
        {
            char[] sentspltfctr = new char[] { '.' };
            List<string> sentences = new List<string>(GetSpeech().Split(sentspltfctr, StringSplitOptions.RemoveEmptyEntries));

        foreach(string sentence in sentences)
            {
                char[] splitFactor = new char[] { ' ', '.', ',' };

                List<string> words = new List<string>(sentence.ToUpper().Split(splitFactor, StringSplitOptions.RemoveEmptyEntries));
                if (words.Contains(x))
                {
                    return sentence;
                }
            }

            return "";

        }
        private static string GetSpeachFromFile()
        {
            string file = @"C:\Users\luis2\OneDrive - Full Sail University\Visual Studios\PG2\Labs\Histogram\Histogram\Histogram\speech.csv";
            using (StreamReader sr = new StreamReader(file))
            {
                string txt = sr.ReadToEnd();
                return txt;
            }
            
        }
        private static void JsonSer(Dictionary<string,int> data, List<string> key, char delimeter)
        {
            string filepath = Console.ReadLine();
            List<string> jsonchk = new List<string>(filepath.Split('.'));
            if(!jsonchk.Contains("json"))
            {
                filepath = filepath + ".json";

            }
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    sw.Write(key[i]);
                    sw.Write(delimeter);
                    sw.Write(data[key[i]]);
                    sw.Write(delimeter);

                }
            }

        }
        private static string[] JsonDser(char delimeter)
        {
            do
            {
                Console.Write("\n\n\nHistogram file name: ");
                string filepath = Console.ReadLine();
                List<string> jsonchk = new List<string>(filepath.Split('.'));
                if (!jsonchk.Contains("json"))
                {
                    filepath = filepath + ".json";

                }
                try
                {

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        string line = sr.ReadLine();
                        string[] data = line.Split(delimeter);
                        return data;
                    }
                }
                catch
                {
                    Console.Write("File not found. Press any key to continue...");
                    Console.WriteLine();
                    Console.ReadKey();
                    
                }
            } while (true);
        }
        private static void RemoveWord(Dictionary<string,int> data,List<string> keys)
            
        {
            do
            {
                Console.WriteLine("Remove:");
                string word = Console.ReadLine().ToLower();
                if (data.ContainsKey(word))
                {
                    data.Remove(word);
                    keys.Remove(word);
                    break;
                }
                else
                {
                    Console.WriteLine("Item not found...");
                    Console.WriteLine("press any key to continue");

                }
            } while (true);
        }




        #endregion
    }
}
