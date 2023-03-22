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
using WpfApp1.Models;

namespace WpfApp1.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для OknoRegistration.xaml
    /// </summary>
    public partial class OknoRegistration : Window
    {
        public OknoRegistration()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
           


            
            {
                Models.Profiles profiles = new Models.Profiles()
                {
                    Surname = FioTb.Text,
                    Name = NameTb.Text,
                    Patronymic = PatronymicTb.Text,
                    Login = LogTb.Text,
                    Password = PassTb.Password
                };
                AppData.Helpers.ClassConnect.panas.Profiles.Add(profiles);
                AppData.Helpers.ClassConnect.panas.SaveChanges();
                MessageBox.Show("Добавлен");

                FioTb.Text = "";
                NameTb.Text = "";
                PatronymicTb.Text = "";
                LogTb.Text = "";
                PassTb.Password = "";
                OknoProfile oknoProfile = new OknoProfile();
                oknoProfile.Show();
                this.Close();
            }

        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
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

        private void CloseAppBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void FioTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
