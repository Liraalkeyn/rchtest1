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
    /// Логика взаимодействия для CompanyPage.xaml
    /// </summary>
    public partial class CompanyPage : Page
    {
        public CompanyPage()
        {
            InitializeComponent();
            using (var dbContext = new Rchtest1Context())
            {
                ListView.ItemsSource = dbContext.Companies.ToList();
            }
        }

        private void Company_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
