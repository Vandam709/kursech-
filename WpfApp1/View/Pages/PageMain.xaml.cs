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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        

        private void Horror_Loft_Click(object sender, RoutedEventArgs e)
        {
            AppData.Helpers.ClassFrame.FrameBody.Navigate(new Pages.PageBody());
            AppData.Helpers.ClassFrame.FrameBody.Navigate(new Pages.PageBody());
        }

        private void Home_Loft_Click(object sender, RoutedEventArgs e)
        {
            AppData.Helpers.ClassFrame.FrameBody.Navigate(new Pages.PageHome());
            AppData.Helpers.ClassFrame.FrameBody.Navigate(new Pages.PageHome());
        }

        private void Tarif_Click(object sender, RoutedEventArgs e)
        {
            AppData.Helpers.ClassFrame.FrameBody.Navigate(new Pages.PageTarif_Kontact());
            AppData.Helpers.ClassFrame.FrameBody.Navigate(new Pages.PageTarif_Kontact());
        }

        private void Planirovanie_Click(object sender, RoutedEventArgs e)
        {
            AppData.Helpers.ClassFrame.FrameBody.Navigate(new Pages.PageBroni());
            AppData.Helpers.ClassFrame.FrameBody.Navigate(new Pages.PageBroni());
        }
    }
}
