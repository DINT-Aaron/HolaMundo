using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            nombreTextBlock.Text = nombreTextBox.Text==""? "Hola mundo!": "Hola " + nombreTextBox.Text + "!";
        }
    }
}
