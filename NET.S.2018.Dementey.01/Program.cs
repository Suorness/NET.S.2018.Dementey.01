namespace NET.S._2018.Dementey._01
{
    using System;

    /// <summary>
    /// Entry point in the program
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 99, 4, 2, 3, 5, 1, -1, 22, -9, 1, 0, 8, 4, 13, 16, 23, 42, 15, 93, 0, 1, 15, -18, -20 };

            Console.WriteLine();
            var newArr1 = Sorter.MergeSort(array);
            var newArr2 = Sorter.QuickSort(array);

            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            foreach (var item in newArr1)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            foreach (var item in newArr2)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
