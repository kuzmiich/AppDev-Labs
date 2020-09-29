using System;
using System.Windows;
using static System.Math;

namespace Laba2
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
        private double defineFunction(double x)
        {
            double fx = Cos(x);
            if (checkBox1.IsChecked == true)
            {
                fx = Cos(x);
            }
            else if (checkBox2.IsChecked == true)
            {
                fx = Sin(x);
            }
            else if (checkBox3.IsChecked == true)
            {
                fx = Tan(x);
            }
            return fx;
        }
        private double isMaxAbs(double fx, double x, double y, double z)
        {
            double maxAbs = 0;
            if (MaxAbs.IsChecked == true)
            {
                maxAbs = Model.FindMaxAbs(fx, x, y, z);
            }
            return maxAbs;
        }
        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            double x = ConvertToDouble(textBox1.Text);
            double y = ConvertToDouble(textBox2.Text);
            double z = ConvertToDouble(textBox3.Text);

            double fx = defineFunction(x);

            double result = Model.Q(fx, x, y, z);
            outPanel.Text += "max(f(x)+y+z, x*y*z) / min(f(x)+y+z, x*y*z)\n"
                + $"X = { x }\n"
                + $"Y = { y }\n"
                + $"Z = { z }\n"
                + $"F(x)={ fx }\n"
                + $"MaxAbs={ isMaxAbs(fx, x, y, z) }\n"
                + $"Результат = { Round(result, 2) }\n";
        }
    }
}
