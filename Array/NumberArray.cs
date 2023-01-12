using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Array
{
    internal class NumberArray : Array
    {
        int number;
        int size;
        int[] arr;
        public int Number
        {
            get => number; set => number = value;
        }
        public int Size
        {
            get => size; set => size = value;
        }
        /// <summary>
        /// Set и Get метод для заполнения 
        /// переменной - члена класса int[] arr.
        /// </summary>
        public int[] Arr
        {
            get => arr; set => arr = value;
        }
        public NumberArray()
        {
            Random random = new Random();
            Size = random.Next(10, 20);
            Arr = new int[Size];
        }
        public int[] FillingArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(0, 10);
            }
            return arr;
        }
        public void PrintArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Write(value + " ");
            }
        }
        public int counter(int[] arr, int number)
        {
            int value = 0;
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    value++;
                }
            }
            return value;
        }
    }
}
