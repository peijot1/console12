using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void QuickSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[right];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }

            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }
    }


    [global::Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] tab = {2 ,3, 4, 56 ,1, 55, 5};
            Program.QuickSort(tab, 0, tab.Length - 1);

            for (int i = 0; i < tab.Length - 1; i++)
            {
                Assert.IsTrue(tab[i] <= tab[i + 1]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] tab = { 2, 3, 4, 56, 1, 55, 5 };
            int[] tab2 = { 1, 2, 3, 4, 5, 55, 56 };
            Program.QuickSort(tab, 0, tab.Length - 1);
            for (int i = 0; i < tab.Length - 1; i++)
            {
                Assert.AreEqual(tab[i], tab2[i]);
            }
        }
    }
}
