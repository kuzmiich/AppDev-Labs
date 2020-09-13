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

        public void Main()
        {
            //DataGrid dataGrid = new DataGrid();
            //dataGrid.Arr = "1";
        }
    }
}
