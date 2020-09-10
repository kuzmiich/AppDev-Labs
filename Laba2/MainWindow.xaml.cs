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
namespace Laba2
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
        private double Q(double fx, double x, double y, double z)
        {
            return Max(fx + y + z, x * y * z) / Min(fx + y + z, x * y * z);
        }
        private double FindMaxAbs(double fx, double x, double y, double z)
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
        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            double x = ConvertToDouble(textBox1.Text);
            double y = ConvertToDouble(textBox2.Text);
            double z = ConvertToDouble(textBox3.Text);
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
            double maxAbs = 0;
            if (MaxAbs.IsChecked == true)
            {
                maxAbs = FindMaxAbs(fx, x, y, z);
            }
            double result = Q(fx, x, y, z);
            outPanel.Text = "\n"
                + $"X = { x }\n"
                + $"Y = { y }\n"
                + $"Z = { z }\n"
                +$"F(x)={ fx }\n"
                +$"MaxAbs={ maxAbs }\n"
                + $"Результат = { Round(result, 2) }";
        }
    }
}
