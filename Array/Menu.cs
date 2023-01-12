using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Array
{
    internal class Menu
    {
        public string[] menuItem;
        public int row;
        public int col;
        public int index;
        /// <summary>
        /// Конструктор по умолчанию, заполняющий переменные - члены класса значениями по умолчанию.
        /// </summary>
        public Menu() 
        {
            menuItem = new string[] { "Пункт 1", "Пункт 2", "Пункт 3", "Пункт 4", "Выход" };
            row = CursorTop;
            col = CursorLeft;
            index = 0;
        }
        /// <summary>
        /// Get и Set методы для переменных - членов данного класса
        /// </summary>
        public string[] MenuItem { get => menuItem; set => menuItem = value; }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public int Index { get => index; set => index = value; }
        /// <summary>
        /// Метод рисующий меню
        /// </summary>
        public void DrawMenu(string[] items, int row, int col, int index)
        {
            SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    BackgroundColor = ForegroundColor;
                    ForegroundColor = ConsoleColor.Black;
                }
                WriteLine(items[i]);
                ResetColor();
            }
            WriteLine();
        }
    }
}
