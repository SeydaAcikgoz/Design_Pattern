using System;

namespace ConsoleApp_Strategy
{

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 50;
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.NextDouble() * 100;
            }

            SortingContext sortingContext = new SortingContext();
            sortingContext.SortList(array, 15);

            //Sorter_Basic sorter = new Sorter_Basic();
           // sorter.Sort(array, 10);

        }
    }
}

