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
    /// Логика взаимодействия для AvtorizationWindow.xaml
    /// </summary>
    public partial class AvtorizationWindow : Window
    {
        public AvtorizationWindow()
        {
            InitializeComponent();
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void CloseAppBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            var enter = AppData.Helpers.ClassConnect.panas.Profiles.Where(i => i.Login == LogTb.Text && i.Password == PassTb.Password).FirstOrDefault();
            if (enter != null)
            {


                OknoProfile oknoProfile = new OknoProfile();
               oknoProfile.Show();
                Close();

            }
            if (enter == null)
            {

                MessageBox.Show("Пользователь не зарегестрирован ");

            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            OknoRegistration oknoRegistration = new OknoRegistration();
            oknoRegistration.Show();
            this.Close();
        }
    }
}
