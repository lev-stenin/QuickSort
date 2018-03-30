using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace QuikSort.Tests
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void TestElements()
        {
            //Тестирование сортировки массива из трёх элементов. После сортировки второй элемент больше первого, третий больше второго
            int[] array = new[] { 33, 22, 11 };
            Program.QuickSort(array);
            Assert.IsTrue(array[0] <= array[1], "Второй элемент должен быть больше первого");
            Assert.IsTrue(array[1] <= array[2], "Третий элемент должен быть больше второго");
        }

        [TestMethod]
        public void TestEqualElements()
        {
            //Тестирование сортировки массива из 100 одинаковых чисел 
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
                array[i] = 2;
            Program.QuickSort(array);
        }

        [TestMethod]
        public void TestRandomElements()
        {
            //Тестирование сортировки массива из 1000 случайных элементов. 
            //Проверить что 10 случайных пар элементов массива после сортировки упорядочены (их пары больший тот, чей индекс больше)          
            int[] array = new int[1000];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();
            Program.QuickSort(array);
            for (int i = 0; i < 10; i++)
            {
                int index = rnd.Next(0, 999);
                Assert.IsTrue(array[index] <= array[index + 1], "В паре большим должен быть тот элемент, чей индекс больше");
            }
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            //Тестирование сортировки пустого массива 
            int[] emptyArray = new int[0];
            Program.QuickSort(emptyArray);
        }

        [TestMethod]
        public void TestBigArray()
        {
            //Тестирование сортировки массива из 1 500 000 000 элементов (100 000 000 элементов)           
            int[] array = new int[100000000];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();
            Program.QuickSort(array);
        }
    }
}