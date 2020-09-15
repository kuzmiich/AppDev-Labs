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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            double x = ViewModel.ConvertToDouble(textBox1.Text);
            double y = ViewModel.ConvertToDouble(textBox2.Text);
            double z = ViewModel.ConvertToDouble(textBox3.Text);
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
                maxAbs = ViewModel.FindMaxAbs(fx, x, y, z);
            }
            double result = ViewModel.Q(fx, x, y, z);
            outPanel.Text += "max(f(x)+y+z, x*y*z) / min(f(x)+y+z, x*y*z)\n"
                + $"X = { x }\n"
                + $"Y = { y }\n"
                + $"Z = { z }\n"
                + $"F(x)={ fx }\n"
                + $"MaxAbs={ maxAbs }\n"
                + $"Результат = { Round(result, 2) }\n";
        }
    }
}
