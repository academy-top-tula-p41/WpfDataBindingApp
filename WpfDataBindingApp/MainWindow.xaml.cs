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

using WpfDataBindingApp.Models;
using WpfDataBindingApp.ViewModels;

namespace WpfDataBindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }

        private void buttonCompanySave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonEmployeeSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}