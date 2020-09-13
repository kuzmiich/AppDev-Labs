using System;

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

        internal int CountWords(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && i != 0 && str[i - 1] != ' ')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
