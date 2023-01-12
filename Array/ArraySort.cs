using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Array
{
    internal class ArraySort : Array
    {
        int minIndex;
        /// <summary>
        /// Set и Get метод для считывания - заполнения 
        /// переменной - члена класса int minIndex.
        /// </summary>
        public int MinIndex
        {
            get => minIndex; set => minIndex = value;
        }
        /// <summary>
        /// Set и Get метод для считывания - заполнения 
        /// переменной - члена класса int size.
        /// </summary>
        public ArraySort()
        {
            Random random = new Random();
            Size = random.Next(10, 20);
            Arr = new int[Size];
            MinIndex = 0;
        }

        ~ArraySort()
        {
            Random random = new Random();
            Size = random.Next(10, 20);
            Arr = new int[Size];
            MinIndex = 0;
        }
        public void Swap (ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
        /// <summary>
        /// Метод возаращающий индекс опорного элемента
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="minIndex"></param>
        /// <param name="MaxIndex"></param>
        /// <returns>опорный элемент</returns>
        public int Partition(int[] arr, int minIndex, int size)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < size; i++)
            {
                if (arr[i] < arr[size])
                {
                    pivot++;
                    Swap(ref arr[pivot], ref arr[i]);
                }
            }

            pivot++;
            Swap(ref arr[pivot], ref arr[size]);
            return pivot;
        }
        /// <summary>
        /// Быстрая сортировка
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns>Сортированный массив</returns>
        static int[] QuickSort(int[] array, int minIndex, int size)
        {
            ArraySort arraySort = new ArraySort();
            if (minIndex >= size)
            {
                return array;
            }

            int pivotIndex = arraySort.Partition(array, minIndex, size);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, size);

            return array;
        }
        public int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }


    }
}
