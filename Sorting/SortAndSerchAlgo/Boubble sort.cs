using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSerchAlgo
{
    public class Boublesort
    {
        public List<string> BubbleSort(List<string> items)
        {
            List<string> _items = items;
            int n = _items.Count;
            bool swapped = true;
            do
            {
                swapped = false;
                for (int j = 1; j < n; j++)
                {
                    if (_items[j - 1].Length > _items[j].Length)
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

    }
    
    
}
