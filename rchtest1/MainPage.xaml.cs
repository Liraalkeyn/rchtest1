using rchtest1.Context;
using System.Windows;
using System.Windows.Controls;

namespace rchtest1;

public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
        using (var dbContext = new Rchtest1Context())
        {
            ListView.ItemsSource = dbContext.Cities.ToList();
        }
    }

    private void City_Click(object sender, RoutedEventArgs e)
    {
        
    }

    private void Add_Click(object sender, System.Windows.Controls.TextChangedEventArgs e)
    {
        
    }
}