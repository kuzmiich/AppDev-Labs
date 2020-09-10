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
        private void MainBtnClick(object sender, RoutedEventArgs e)
        {
            double xn, xk;
            xn = Convert.ToDouble(textBox1.Text);
            xk = Convert.ToDouble(textBox2.Text);
            int k = 10;
            double h = (xk - xn) / k;
            var YX = FunctionYx(xn, xk, h);
            var SX = FunctionSx(xn, xk, h);

            outPanel.Text = "|   x   |    S(x)     | Y(x)\n"
            + "-----------------------------------\n";
            while (xn < xk)
            {
                outPanel.Text += 
                $"| {xn:F5} | {SX[0]:F3} | {YX[0]:F3}|\n"
                + "-------------------------------------\n";
                xn += h;
            }
            
        }
        private List<double> FunctionYx(double xn, double xk, double h)
        {
            List<double> fList = new List<double>() { };
            double f;
            while (xn <= xk)
            {
                f = 1 / 4 * ( ((xn + 1) / Sqrt(xn)) * Asinh(Sqrt(xn)) - Acosh(Sqrt(xn)));
                fList.Add(f);
                xn += h;
            }
            return fList;
        }
        private List<double> FunctionSx(double xn, double xk, double h)
        {
            List<double> sxList = new List<double>() {};

            double f, T, sum;
            while (xn <= xk)
            {
                f = 1;
                sum = f;
                int n = 0;
                while (n < 500)
                {
                    T = ((n + 1) * xn / ((4 * n + 1) * Pow(xn, 2)));
                    f *= T;
                    sum += f;
                    n++;
                }
                sxList.Add(sum);
                xn += h;
            }
            return sxList;
        }
    }
}
