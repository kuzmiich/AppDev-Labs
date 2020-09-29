using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Laba5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private static double ConvertToDouble(string value)
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
        private void ComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox.Text = "hi";
        }

        private void ExitBtnClick(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Do you really want to exit?", "Exiting...",
                                           MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {
                e.Handled = true;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
