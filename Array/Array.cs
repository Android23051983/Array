using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Array
{
    internal class Array
    {
        protected int[] arr;
        protected int size;

        /// <summary>
        /// Set и Get метод для заполнения 
        /// переменной - члена класса int size.
        /// </summary>
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

        /// <summary>
        /// Метод заполняющий массив случайными числами от 0 до 10.
        /// </summary>
        /// <returns>Возвращает заполненный массив</returns>
        public int[] FillingArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(0, 10);
            }
            return arr;
        }

        /// <summary>
        /// Метод выводящий любой заполненный массив на экран консоли.
        /// </summary>
        /// <param name="arr">принимает любой внешний массив данных</param>
        public void PrintArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Write(value + " ");
            }
        }
    }
}
