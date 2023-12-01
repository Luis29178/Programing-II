using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> minivans = new Dictionary<string, string>()

{
                

    { "Ford", "Aerostar" },


    { "Honda", "Odyssey"},


    { "Toyota", "Sienna"}
                
};
            
if (minivans.TryGetValue("Nissan", out string model))
                
{
                
        Console.WriteLine($"Nissan Model: {model}");
                
}








            Console.ReadKey();
        }
    }
}
class Animal

{
    
     public void Show() { Console.Write("Animal"); }
    
}

class Dog : Animal

{
	
      public void Show() { base.Show(); Console.Write("Dog"); }
	
}
