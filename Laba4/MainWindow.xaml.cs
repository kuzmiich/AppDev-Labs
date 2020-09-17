using System;
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
        public static double ConvertToDouble(object sender, EventArgs e, string value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Error, ", Convert.ToString(ex) );
                return 0;
            }
        }
        private void MainBtnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
