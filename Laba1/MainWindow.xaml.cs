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
        private double Calculate(double x, double y, double z)
        {
            return (Pow(y, (x + 1)) / (Pow(Abs(y - 2), 1 / 3) + 3)) + ((x + (y / 2)) / (2 * Abs(x + y)) * Pow(x + 1, -1 / Sin(z)));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Num1 = textBox1.Text;
            string Num2 = textBox2.Text;
            string Num3 = textBox3.Text;
            double x = 0, y = 0, z = 0;
            try
            {
                x = Convert.ToDouble(Num1);
                y = Convert.ToDouble(Num2);
                z = Convert.ToDouble(Num3);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error, ", ex);
            }
            double result = Calculate(x, y, z);
            OutPanel.Text = "g = (y^(x+1) / (|x-y|^(1/3) + 3)) + ((x + y/2) / 2*|x+y|(x+1)^(-1/sin(z)))"+"\n"
                + "X = " + Num1 + "\n"
                + "Y = " + Num2 + "\n"
                + "Z = " + Num3 + "\n"
                + "Результат = " + Round(result, 2);
        }
    }
}
