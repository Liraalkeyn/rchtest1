using rchtest1.Context;
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

namespace rchtest1
{
    /// <summary>
    /// Логика взаимодействия для TransportPage.xaml
    /// </summary>
    public partial class TransportPage : Page
    {
        public TransportPage()
        {
            InitializeComponent();
            using (var dbContext = new Rchtest1Context())
            {
                ListView.ItemsSource = dbContext.Transports.ToList();
            }
        }

        private void Transport_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
