using static System.Math;

namespace Laba2
{
    class Model
    {
        public static double Q(double fx, double x, double y, double z)
        {
            return Max(fx + y + z, x * y * z) / Min(fx + y + z, x * y * z);
        }
        public static double FindMaxAbs(double fx, double x, double y, double z)
        {
            int count = 4;
            double max = 0;
            double[] arr = new double[] { fx, x, y, z };
            for (int i = 0; i < count; i++)
            {
                if (Abs(arr[i]) > max)
                {
                    max = Abs(arr[i]);
                }
            }
            return max;
        }
    }
}
