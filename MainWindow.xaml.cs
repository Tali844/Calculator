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

namespace Calculator
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

        private void Plus(object sender, RoutedEventArgs e)
        {
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);
            int ans = n1 + n2;
            answer.Text += ans;
            answer.Visibility = Visibility.Visible;
        }

        private void Minus(object sender, RoutedEventArgs e)
        {

        }

        private void Mult(object sender, RoutedEventArgs e)
        {

        }

        private void Div(object sender, RoutedEventArgs e)
        {

        }
    }
}