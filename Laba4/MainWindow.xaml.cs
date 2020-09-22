using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Laba4
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        public static int ConvertToInt(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show( Convert.ToString(ex) );
                return 0;
            }
        }

        List<int[,]> elements = new List<int[,]>();
        private void MainBtnClick(object sender, RoutedEventArgs e)
        {
            int N = ConvertToInt(textBox1.Text);
            int M = ConvertToInt(textBox2.Text);

            int[,] arr = Model.StringSwap(N, M);
            
            dGrid.ItemsSource = arr;
            
            dGrid.Items.Refresh();
        }

        private void EnableEdit(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = Model.TargetChange(textBox1.IsEnabled);
            textBox2.IsEnabled = Model.TargetChange(textBox2.IsEnabled);
        }
    }
}
