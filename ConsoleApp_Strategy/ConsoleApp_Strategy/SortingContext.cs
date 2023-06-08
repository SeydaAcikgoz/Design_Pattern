namespace ConsoleApp_Strategy
{
    public class SortingContext
    {
        private ISorter smallSorter = new SmallSorter();
        private ISorter mediumSorter = new MediumSorter();
        private ISorter largeSorter = new LargeSorter();

        public void SortList(double[] array, int size)
        {
            if (size <= 10)
            {
                smallSorter.Sort(array, size);
            }
            else if (size <= 20)
            {
                mediumSorter.Sort(array, size);
            }
            else
            {
                largeSorter.Sort(array, size);
            }
        }

    }
}

