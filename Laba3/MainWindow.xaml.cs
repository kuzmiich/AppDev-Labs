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
        private double ConvertToDouble(string value)
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
        private List<double> FunctionYx(double xn, double xk, double h)
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
        private List<double> FunctionSx(double xn, double xk, double h)
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
        private void MainBtnClick(object sender, RoutedEventArgs e)
        {
            double xn, xk;
            xn = ConvertToDouble(textBox1.Text);
            xk = ConvertToDouble(textBox2.Text);
            int k = 12;
            double h = (xk - xn) / k;

            var YX = FunctionYx(xn, xk, h);
            var SX = FunctionSx(xn, xk, h);

            outPanel.Text = "|   x   |  S(x)  |  Y(x) |\n"
                            + "---------------------------\n";
            int i = 0;
            while (xn <= xk)
            {
                outPanel.Text += 
                $"| {xn:F3} | {SX[i]:F3} | {YX[i]:F3} |\n"
                + "--------------------------\n";
                i++;
                xn += h;
                xn = Round(xn, 2);
            }
            
        }
    }
}
