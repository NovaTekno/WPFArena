using System.Windows;

namespace DialogBoxDemo;

public partial class DetailsDialog : Window
{
    public DetailsDialog()
    {
        InitializeComponent();
    }
    
    public string FullName { get; private set; }
    public string City { get; private set; }

    private void OnOK(object sender, RoutedEventArgs e)
    {
        FullName = _name.Text;
        City = __city.Text;
        DialogResult = true;
        Close();
    }

    private void OnCancel(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }
}