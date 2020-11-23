using Laba9.ViewModels;
using System.Windows;
using System.Windows.Media;

namespace Laba9.View
{
    /// <summary>
    /// Interaction logic for RGBColorWidget.xaml
    /// </summary>
    public partial class RGBColorWidget : Window
    {
        public RGBViewModel viewModel { get; set; }
        public Color ResultColor { get; set; }
        public RGBColorWidget()
        {
            InitializeComponent();
            viewModel = new RGBViewModel();
        }
        public RGBColorWidget(RGBViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ColorWidget.DataContext = this;
            ColorWidget.OkButton.Click += Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultColor = viewModel.CurrentColor;
            DialogResult = true;
        }
    }
}
