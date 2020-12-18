using Laba10.modules;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Laba10
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

        private static readonly string path = "settings.json";
        private static readonly JsonFileReader jsonFileReader = new JsonFileReader(path);
        private void ReadJsonFile()
        {

            Width = Convert.ToInt32(jsonFileReader.ReadFile()); 
            Height = Convert.ToInt32(jsonFileReader.ReadFile());
            Title = Convert.ToString(jsonFileReader.ReadFile());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReadJsonFile();
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            /*string text = StringComboBox.Text;
            if (text.Length > 0)
            {
                StringComboBox.Text = string.Empty;
                _strings.Add(text.Trim());
            }*/
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
