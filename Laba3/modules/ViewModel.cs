using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Laba3
{
    class ViewModel
    {
        public static double ConvertToDouble(string value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch (System.FormatException)
            {
                return 0;
            }
        }
        public static List<double> FunctionYx(double xn, double xk, double h)
        {
            List<double> fList = new List<double>() { };
            while (xn <= xk)
            {
                double yx = (1 / 4.0) * ((xn + 1) / Sqrt(xn) * Sinh(Sqrt(xn)) - Cosh(Sqrt(xn)));
                fList.Add(yx);
                xn += h;
                xn = Round(xn, 2);
            }
            return fList;
        }
        public static List<double> FunctionSx(double xn, double xk, double h)
        {
            List<double> sxList = new List<double>() { };

            double f, T, sum;
            while (xn <= xk)
            {
                f = xn / 6;
                sum = f;
                int n = 1;
                while (n < 500)
                {
                    T = ((n + 1) * xn / ((4 * n + 6) * Pow(n, 2)));
                    f *= T;
                    sum += f;
                    n++;
                }
                sxList.Add(sum);
                xn += h;
                xn = Round(xn, 2);
            }
            return sxList;
        }
    }
}
