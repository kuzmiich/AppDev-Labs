using System;
using System.Windows;
using static System.Math;

namespace Laba3
{
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
                MessageBox.Show( Convert.ToString(ex) );
                return 0;
            }
        }
        private void MainBtnClick(object sender, RoutedEventArgs e)
        {
            double xn = 0, xk = 0;
            xn = ConvertToDouble(textBox1.Text);
            xk = ConvertToDouble(textBox2.Text);
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
