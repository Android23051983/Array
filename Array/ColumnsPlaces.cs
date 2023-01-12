using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Array
{
    internal class ColumnsPlaces
    {
        int[,] arr;
        int m;
        int n;
        int z1;
        int z2;
        int temp;

        public int M { get => m; set => m = value; }
        public int N { get => n; set => n = value; }
        public int Z1 { get => z1; set => z1 = value; }
        public int Z2 { get => z2; set => z2 = value; }
        public int[,] Arr { get => arr; set => arr = value; }
        public int Temp { get => temp; set => temp = value; }
        public ColumnsPlaces() {}

        public int[,] FillingArray()
        {
            F:
            Write("Введите количество строк: ");
            string T1 = ReadLine();
            if (String.IsNullOrEmpty(T1))
            {
                WriteLine("Забыли ввести цифру!!!");
                WriteLine("Введите цифры заново!!!");
                goto F;
            }
            else
            {
                M = Convert.ToInt32(T1);
            }
            Write("Введите количество столбцов: ");
            string T2 = ReadLine();
            if (String.IsNullOrEmpty(T2))
            {
                WriteLine("Забыли ввести цифру!!!");
                WriteLine("Введите цифры заново!!!");
                goto F;
            }
            else
            {
                N = Convert.ToInt32(T2);
            }
            int[,] Arr = new int[M, N];
            Random rnd = new Random();
            for(int i=0; i<M; i++)
            {
                for(int j=0; j<N; j++)
                {
                    Arr[i,j] = rnd.Next(0, 10);
                }
            }
            return Arr;
        }

        public int[,] ReplacingColumns(int[,] Arr)
        {
        Found:
            Write($"Введите столбец для замены от 0 до {N - 1}: ");
            string T1 = ReadLine();
            if (String.IsNullOrEmpty(T1))
            {
                WriteLine("Забыли ввести цифру!!!");
                WriteLine("Введите цифры заново!!!");
                goto Found;
            }
            else
            {
                Z1 = Convert.ToInt32(T1); 
            }
            Write($"Введите второй столбец для замены от 0 до {N - 1}: ");
            string T2 = ReadLine();
            if (String.IsNullOrEmpty(T2))
            {
                WriteLine("Забыли ввести цифру!!!");
                WriteLine("Введите цифры заново!!!");
                goto Found;
            }
            else
            { Z2 = Convert.ToInt32(T2); } 
    
            if (Z1 > n-1 || Z2 > n-1 || Z1 == Z2)
            {
                WriteLine("Номера столбцов введены неверно ");
                goto Found;
            }
            for(int i=0; i<M; i++)
            {
                Temp = Arr[i, Z1];
                Arr[i, Z1] = Arr[i, Z2];
                Arr[i, Z2] = Temp;
            }
            return Arr;
            
        }
        public void Print2dArray(int[,] arr)
        {
            for (int i=0; i<M; i++)
            {
                for(int j=0; j<N; j++)
                {
                    Write(arr[i,j] + " ");
                }
                WriteLine();
            }
        }
    }
}
