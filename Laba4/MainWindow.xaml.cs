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


        private void MainBtnClick(object sender, RoutedEventArgs e)
        {
            int N = ConvertToInt(textBox1.Text);
            int M = ConvertToInt(textBox2.Text);
            var arr = ViewMadel.StringSwap(N, M);
            List<int[,]> elements = new List<int[,]> ();

            elements.Add(arr);
            dGrid.ItemsSource = elements;
            dGrid.Items.Refresh();
        }
    }
}
