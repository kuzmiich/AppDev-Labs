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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainBtnClick(object sender, RoutedEventArgs e)
        {
            double xn = 0, xk = 0;
            xn = ViewModel.ConvertToDouble(textBox1.Text);
            xk = ViewModel.ConvertToDouble(textBox2.Text);
            int k = 12;
            double h = (xk - xn) / k;
            if (h == 0)
            {
                h = 1;
            }
            var YX = ViewModel.FunctionYx(xn, xk, h);
            var SX = ViewModel.FunctionSx(xn, xk, h);

            string line = "---------------------------\n";
            outPanel.Text = "|   x   |  S(x)  |  Y(x) |\n" + line;

            int i = 0;
            while (xn <= xk)
            {
                outPanel.Text +=
                $"| {xn:F3} | {SX[i]:F3} | {YX[i]:F3} |\n" + line;
                i++;
                xn += h;
                xn = Round(xn, 2);
            }
        }
    }
}
