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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.View.Windows;

namespace WpfApp1.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageHome.xaml
    /// </summary>
    public partial class PageHome : Page
    {
        public PageHome()
        {
            InitializeComponent();
        }

        private void BronBT_Click(object sender, RoutedEventArgs e)
        {
            DobavlenieBroni dobavlenieBroni = new DobavlenieBroni();
            dobavlenieBroni.Show();
        }
    }
}
