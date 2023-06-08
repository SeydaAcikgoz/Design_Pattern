using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_Strategy
{
    public class SmallSorter : ISorter
    {
        public void Sort(double[] array, int size)
        {
            List<double> list = array.ToList();

            IComparer<double> comparer = null;
            list.Sort(0, size, comparer);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(list[i].ToString(".00"));
            }

            Console.WriteLine(" ilk " + size + " veri için sırala");

        }
    }
}

