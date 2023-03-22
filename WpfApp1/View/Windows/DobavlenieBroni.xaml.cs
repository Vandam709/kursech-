using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfApp1.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для DobavlenieBroni.xaml
    /// </summary>
    public partial class DobavlenieBroni : Window
    {
        public DobavlenieBroni()
        {
            InitializeComponent();
        }

        private void CloseAppBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void BronBt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Забронировано");
            OknoProfile oknoProfile = new OknoProfile();
            oknoProfile.Show();
            Close();
        }
    }
}
