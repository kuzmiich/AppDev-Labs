using System;
using System.Collections.Generic;
using System.Data;
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

            dGrid.ItemsSource = Model.Gen(N, M);
            /*dGrid.FormA();
            var data = new double[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    data[i, j] = dGrid.Items[i, j];
                }
            }
            dGrid.ItemsSource = data.AsTupleList();*/
            dGrid.Items.Refresh();
        }
    }
}
