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

        private static readonly string pathSettings = "settings.json";
        private static readonly string pathEntry = "file.json";
        private static readonly JsonFileReader _jsonFileReader = new JsonFileReader(pathSettings);
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
            _jsonFileReader.WriteFile(new ProjectObject(Title, (int)Width, (int)Height, sourceTextBox.Text));
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private async void button_Execute(object sender, RoutedEventArgs e)
        {
            var commandType = listBox.SelectedItem.ToString();
            var jsonFileReader = new JsonFileReader(pathEntry);
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
