using Laba10.modules;
using System;
using System.Collections.ObjectModel;
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
        private static readonly JsonFileReader _jsonFileReader = new JsonFileReader(path);
        private async void ReadJsonFile()
        {
            var projectSettings = await _jsonFileReader.ReadFile();
            Width = projectSettings.Width;
            Height = projectSettings.Height;
            Title = projectSettings.Title;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] commands = { "read", "write" };
            listBox.Items.Add(commands[0]);
            listBox.Items.Add(commands[1]);
            ReadJsonFile();
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string text = sourceTextBox.Text;
            ProjectObject _data = new ProjectObject(string.Empty, 0, 0, string.Empty);
            if (text.Length > 0)
            {
                sourceTextBox.Text = string.Empty;
                _data.Content = text;
            }
            string path = "file.json";
            var jsonFileReader = new JsonFileReader(path);
            jsonFileReader.WriteFile(_data);
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _jsonFileReader.WriteFile(new ProjectObject(Title, (int)Width, (int)Height, string.Empty));
            Application.Current.Shutdown();
        }

        private async void button_Execute(object sender, RoutedEventArgs e)
        {
            var commandType = listBox.SelectedItem.ToString();
            var path = "file.json";
            var jsonFileReader = new JsonFileReader(path);
            var text = sourceTextBox.Text;
            var obj = new ProjectObject(string.Empty, 0, 0, text);
            if (commandType == "write")
            {
                jsonFileReader.WriteFile(obj);
            } 
            else
            {
                var projectObj = await jsonFileReader.ReadFile();
                resultTextBox.Text = projectObj.Content;
            }
        }
    }
}
