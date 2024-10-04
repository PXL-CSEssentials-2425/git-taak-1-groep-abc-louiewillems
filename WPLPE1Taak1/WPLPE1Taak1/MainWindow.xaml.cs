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

namespace WPLPE1Taak1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Brush mainWindowBrush;
        public MainWindow()
        {
            InitializeComponent();
            mainWindowBrush = mainGrid.Background;
        }

        private void pxlImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainGrid.Background = new SolidColorBrush(Colors.Black);
        }

        private void pxlImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainGrid.Background = mainWindowBrush;

        }
    }
}