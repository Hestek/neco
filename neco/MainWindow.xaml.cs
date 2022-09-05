using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace neco
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += Window1_KeyDown;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            
            
        }

        void Window1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.System && e.SystemKey == Key.F4)
            {
                e.Handled = true;
            }
        }

        private void trollbutton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int col = random.Next(0, 20);
            int row = random.Next(0, 20);

            Grid.SetColumn(trollbutton, col);
            Grid.SetRow(trollbutton, row);
        }
        void ChangeButtonRow()
        {

        }
    }
}
