using Laba10.modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Laba10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly JsonFileReader _jsonFileReader = new JsonFileReader("settings.json");
        public MainWindow()
        {
            InitializeComponent();
        }
        private ObservableCollection<string> _strings = new ObservableCollection<string>();

        private void ReadIniFile()
        {
            Width = Convert.ToInt32(JsonFileReader.ReadFile().Width); 
            Height = Convert.ToInt32(JsonFileReader.ReadFile().Height);
            Title = Convert.ToString(JsonFileReader.ReadFile().Title);
        }
        private void AddRange(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                _strings.Add(item);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReadIniFile();
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string text = .Text;
            if (text.Length > 0)
            {
                StringComboBox.Text = string.Empty;
                _strings.Add(text.Trim());
            }
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void StringComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
            string item = comboBox?.SelectedItem?.ToString();
            if (item != null)
            {
                ResultTextBlock.Clear();
                string[] words = item.Split();
                Array.Sort(words);
                ResultTextBlock.Text = string.Join('\n', words);
            }
        }

        private void Window_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}
