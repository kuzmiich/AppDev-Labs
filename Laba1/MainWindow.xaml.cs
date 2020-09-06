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
        private string result()
        {
            return "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = result();
            
        }

        private string textBox1_Changed(object sender, TextChangedEventArgs e)
        {
            string text = textBox1.Text;
            return text;
        }

        private string textBox2_Changed(object sender, TextChangedEventArgs e)
        {
            string text = textBox2.Text;
            return text;
        }

        private string textBox3_Changed(object sender, TextChangedEventArgs e)
        {
            string text = textBox3.Text;
            return text;
        }
    }
}
