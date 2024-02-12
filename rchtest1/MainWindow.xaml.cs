using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rchtest1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
    }

    private void FrameNavigated(object sender, NavigationEventArgs e)
    {
        
    }

    private void City(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new MainPage();
    }

    private void Employee(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new EmployeePage(); 
    }

    private void Company(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new CompanyPage();
    }

    private void Position(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new PositionPage();
    }

    private void Transport(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new TransportPage();
    }

    private void TypeCargo(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new TypeCargoPage();
    }

}