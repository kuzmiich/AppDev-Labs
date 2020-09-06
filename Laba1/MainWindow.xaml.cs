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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Num1 = textBox1.Text;
            string Num2 = textBox2.Text;
            string Num3 = textBox3.Text;
            double x = Convert.ToDouble(Num1);
            double y = Convert.ToDouble(Num2);
            double z = Convert.ToDouble(Num3);
            double result = (Math.Pow(y,(x+1)) / (Math.Pow(Math.Abs(y - 2), 1/3) + 3)) + ((x + (y/2))/(2 * Math.Abs(x + y)) * Math.Pow(x + 1, -1/Math.Sin(z)));
            OutPanel.Text = "X = " + Num1 + "\n"
                + "Y = " + Num2 + "\n"
                + "Z = " + Num3 + "\n"
                + "Результат = " + Math.Round(result, 2);
        }
    }
}
