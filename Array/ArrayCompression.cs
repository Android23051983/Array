using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Array
{
    internal class ArrayCompression : Array
    {
        int count;
        
        /// <summary>
        /// Set и Get метод для заполнения
        /// переменной - члена класса int count.
        /// </summary>
        public int Count
        { 
            get => count; set => count = value;
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// инициализирующий переменные - члены класса значениями по умолчанию
        /// </summary>
        public ArrayCompression() 
        {
            Random random = new Random();
            Size = random.Next(10, 20);
            Arr = new int[Size];
            Count = 0;
        }
        ~ArrayCompression() 
        {
            Random random = new Random();
            Size = random.Next(10, 20);
            Arr = new int[Size];
            Count = 0;
        }
       
        /// <summary>
        /// Метод проверяющий массив на наличие ячеки равной 0,
        /// сдвиг массива относителдьно ячейки со значением 0 в лево.
        /// Запись в освободившиеся справа ячейки значения -1.
        /// </summary>
        /// <param name="arr">Принимает заполненный массив</param>
        /// <returns>Возвращает изменённый массив</returns>
        public int[] arrayCompression(int[] arr)
        {
            for (int i=0; i<Size; i++)
            {
                if (arr[i] == 0)
                {
                    Size--;
                    for(int j=i; j<Size; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[Size] = -1;
                    i--;
                }
            }
            return arr;
        }
    }
}
