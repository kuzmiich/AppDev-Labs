using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4
{
    class ViewMadel
    {
        private static double ConvertToDouble(string value)
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

        public List<Grid> myElements { get; }

        public void GridElement()
        {
            //DataGrid dataGrid = new DataGrid();
            //dataGrid.Arr = "1";
        }
        internal string StringSwap(int N, int M)
        {
            Random rand = new Random();
            int[,] arr = new int[N, M];
            int start = -100, end = 100;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = start + rand.Next(start, end);
                    Console.WriteLine(arr[i, j]);
                }
            }
            return "";
        }
    }
}
