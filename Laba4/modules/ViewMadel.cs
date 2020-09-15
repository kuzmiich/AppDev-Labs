using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4
{
    class ViewMadel
    {
        internal static double ConvertToDouble(string value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Error ", ex);
                return 0;
            }
        }
        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        /*public List<Grid> myElements { get; }

        public void GridElement()
        {
            //DataGrid dataGrid = new DataGrid();
            //dataGrid.Arr = "1";
        }*/
        private static void Gen(ref int[,] arr, int N, int M, Random rand)
        {
            int start = -100, end = 100;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = start + rand.Next(start, end);
                }
            }
        }

        private static void SwapMaxAndMinStr(ref int[,] arr, int N, int M)
        {
            int max = arr[0, 0], min = arr[0, 0];
            int minIndStr = 0, maxIndStr = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxIndStr = i;
                    }
                    else if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minIndStr = i;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Swap(ref arr[minIndStr, j], ref arr[maxIndStr, j]);
                }
            }
        }

        public int[,] StringSwap(int N, int M)
        {
            Random rand = new Random();
            int[,] arr = new int[N, M];
            Gen(ref arr, N, M, rand);

            int[,] sourseElements = arr;

            SwapMaxAndMinStr(ref arr, N, M);
            int[,] resultElements = arr;

            return resultElements;
        }
    }
}
