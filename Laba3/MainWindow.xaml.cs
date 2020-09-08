using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Math;

namespace Laba3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Main()
        {
            double xn, xk;
            Console.WriteLine("Введите xn");
            xn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите xk");
            xk = Convert.ToDouble(Console.ReadLine());

            FunctionSx(xn, xk);

            Console.WriteLine("|   x   |    F      |   n   |\n");
            Console.WriteLine("-------------------------------------------------\n");

            //Console.WriteLine(String.Format("| {0:f2} | {1:f10} | {2:d5}|\n", xn, sum, n));
            Console.WriteLine("-------------------------------------------------\n");
        }
        private double Function_Yx()
        {
            return 1;
        }
        private List<double> FunctionSx(double xn, double xk)
        {
            int k = 10;
            double h = (xk - xn) / k;
            List<double> sx_list = new List<double>() {};
            List<double> xn_list = new List<double>() { };

            double f, T, sum;
            while (xn <= xk)
            {
                f = 1;
                sum = f;
                int n = 0;
                while (n < 500)
                {
                    T = ((n + 1)) * xn / ((4 * n + 1) * (Pow(xn, 2)));
                    f *= T;
                    sum += f;
                    n++;
                }
                
                sx_list.Add(sum);
                xn += h;
            }
            return sx_list;
        }
    }
}
