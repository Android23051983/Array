using System;
using static System.Console;
namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new ();
            menu.MenuItem[0] = "Сжатие массива с переносом 0 в конец массива и заменой на -1";
            menu.MenuItem[1] = "Сортировка массива на отрицательные и положительные числа";
            menu.MenuItem[2] = "Сколько раз введённое число встречается в массиве";
            menu.MenuItem[3] = "В Двумерном массиве поменять местами указанные столбцы";
            while (true)
            {
                menu.DrawMenu(menu.MenuItem, menu.Row, menu.Col, menu.Index);
                switch (ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (menu.Index < menu.MenuItem.Length - 1)
                            menu.Index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (menu.Index > 0)
                            menu.Index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (menu.Index)
                        {
                            case 0:
                                ArrayCompression arrayCompression = new ();
                                int[] arrCompression = arrayCompression.FillingArray();
                                arrayCompression.PrintArray(arrCompression);
                                arrayCompression.arrayCompression(arrCompression);
                                WriteLine();
                                arrayCompression.PrintArray(arrCompression);
                                ReadKey();
                                Clear();
                                break;
                            case 1:
                                ArraySort arraySort = new ();
                                int[] arrSort = arraySort.FillingArray();
                                WriteLine("Неотсортированный массив");
                                arraySort.PrintArray(arrSort);
                                arraySort.QuickSort(arrSort);
                                WriteLine();
                                WriteLine("Отсортированный массив");
                                arraySort.PrintArray(arrSort);
                                ReadKey();
                                Clear();
                                break; 
                            case 2:
                                NumberArray numberArray = new NumberArray();
                                int[] arrNumber = numberArray.FillingArray();
                                numberArray.PrintArray(arrNumber);
                                WriteLine();
                                Write("Введите число от 0 до 9 для проверки: ");
                                int number = Convert.ToInt32(ReadLine());
                                int value = numberArray.counter(arrNumber, number);
                                WriteLine("Кол-во: " + value);
                                ReadKey();
                                Clear();
                                break; 
                            case 3:
                                ColumnsPlaces columnsPlaces = new ColumnsPlaces();
                                int[,] arr = columnsPlaces.FillingArray();
                                WriteLine("Исходный массив");
                                columnsPlaces.Print2dArray(arr);
                                columnsPlaces.ReplacingColumns(arr);
                                WriteLine("Изменённый массив");
                                columnsPlaces.Print2dArray(arr);
                                WriteLine("Нажмите ENTER для продолжения");
                                ReadLine();
                                Clear();
                                break;
                            default:
                                WriteLine("Выбран выход из приложения");
                                return;
                        }
                        break;
                }
            }
        

            
           
        }
    }
}