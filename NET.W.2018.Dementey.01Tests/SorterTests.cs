using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NET.W._2018.Dementey._01.Tests
{
    [TestClass()]
    public class SorterTests
    {
        [TestMethod()]
        public void QuickSortTest()
        {
            int[] array = new int[] { 99, 4, 2, 3, 5, 1, -1, 22, -9, 1, 0, 8, 4, 13, 16, 23, 42, 15, 93, 0, 1, 15, -18, -20 };

            var sortedArray = Sorter.QuickSort(array);

            for (int i =0; i<sortedArray.Length-1; i++)
            {
                if (sortedArray[i] > sortedArray[i + 1])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod()]
        public void MergeSortSortTest()
        {
            int[] array = new int[] { 99, 4, 2, 3, 5, 1, -1, 22, -9, 1, 0, 8, 4, 13, 16, 23, 42, 15, 93, 0, 1, 15, -18, -20 };

            var sortedArray = Sorter.MergeSort(array);

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                if (sortedArray[i] > sortedArray[i + 1])
                {
                    Assert.Fail();
                }
            }
        }



        [TestMethod()]
        public void QuickSortSameArrayTest()
        {
            int[] array = new int[] { 0,0,0 };

            var sortedArray = Sorter.QuickSort(array);

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                if (sortedArray[i] > sortedArray[i + 1])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod()]
        public void MergeSortSameArrayTest()
        {
            int[] array = new int[] { 0, 0, 0 };

            var sortedArray = Sorter.MergeSort(array);

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                if (sortedArray[i] > sortedArray[i + 1])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod()]
        public void QuickSortArrayWithOneNumberTest()
        {
            int[] array = new int[] { 1 };

            var sortedArray = Sorter.QuickSort(array);

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                if (sortedArray[i] > sortedArray[i + 1])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod()]
        public void MergeSortArrayWithOneNumberTest()
        {
            int[] array = new int[] { 1 };

            var sortedArray = Sorter.MergeSort(array);

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                if (sortedArray[i] > sortedArray[i + 1])
                {
                    Assert.Fail();
                }
            }
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void QuickSortEmptyArrayTest()
        {
            int[] array = new int[] { };

            var sortedArray = Sorter.QuickSort(array);

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MergeSortEmptyArrayTest()
        {
            int[] array = new int[] { };

            var sortedArray = Sorter.MergeSort(array);

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSortNullArrayTest()
        {
            int[] array = null;

            var sortedArray = Sorter.QuickSort(array);

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSortNullArrayTest()
        {
            int[] array = null;

            var sortedArray = Sorter.MergeSort(array);

        }
    }
}