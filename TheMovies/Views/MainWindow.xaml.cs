using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheMovies.Views;

namespace TheMovies
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

        private void AddBookingClick(object sender, RoutedEventArgs e)
        {
            AddMenu addMenu = new AddMenu();
            addMenu.Top = this.Top;
            addMenu.Left = this.Left;
            addMenu.Show();
            this.Close();
        }
    }
}