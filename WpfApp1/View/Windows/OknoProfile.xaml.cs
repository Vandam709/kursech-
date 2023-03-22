using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
using WpfApp1.View.Pages;

namespace WpfApp1.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для OknoProfile.xaml
    /// </summary>
    public partial class OknoProfile : Window
    {
        public OknoProfile()
        {
            InitializeComponent();
            AppData.Helpers.ClassFrame.FrameMain = FrameMenuMain;
            FrameMenuMain.Navigate(new View.Pages.PageMain());
            AppData.Helpers.ClassFrame.FrameBody = FrameBodyMain;
            FrameBodyMain.Navigate(new View.Pages.PageBody());
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

       

        private void CloseAppBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
