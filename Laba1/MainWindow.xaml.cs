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

namespace Laba1
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
        private double Calculate(double x, double y, double z)
        {
            return (Pow(y, (x + 1)) / (Pow(Abs(y - 2), 1 / 3) + 3)) + ((x + (y / 2)) / (2 * Abs(x + y)) * Pow(x + 1, -1 / Sin(z)));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str1 = textBox1.Text;
            string Str2 = textBox2.Text;
            string Str3 = textBox3.Text;
            double x = ConvertToDouble(str1);
            double y = ConvertToDouble(str1);
            double z = ConvertToDouble(str1);

            double result = Calculate(x, y, z);
            OutPanel.Text = "g = (y^(x+1) / (|x-y|^(1/3) + 3)) + ((x + y/2) / 2*|x+y|(x+1)^(-1/sin(z)))"+"\n"
                + "X = " + str1 + "\n"
                + "Y = " + Str2 + "\n"
                + "Z = " + Str3 + "\n"
                + "Результат = " + Round(result, 2);
        }
    }
}
