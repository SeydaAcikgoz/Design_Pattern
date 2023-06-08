using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_Strategy
{
    public class Sorter_Basic //Strategy tasarım desenine uygun değildir.
    {
        public void Sort(double[] array, int size)
        {
            List<double> list = array.ToList();
  
            int lenght = array.Length;
          
            if (size <= 10)
            {
                IComparer<double> comparer = null;
                list.Sort(0, size, comparer);

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(list[i].ToString(".00"));
                }

                Console.WriteLine(" ilk " + size + " veri için sırala");
            }
            else if (size <= 20)
            {
                IComparer<double> comparer = null;
                list.Sort(0, size, comparer);

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(list[i].ToString("."));
                }

                Console.WriteLine(" ilk " + size + " veri için sırala");
            }
            else
            {
                IComparer<double> comparer = null;
                list.Sort(0, size, comparer);

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(list[i].ToString(".0"));
                }

                Console.WriteLine(" ilk " + size + " veri için sırala");
            }
        }
    }
}
