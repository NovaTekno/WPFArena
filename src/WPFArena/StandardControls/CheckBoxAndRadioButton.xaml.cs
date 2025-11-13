using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WPFArena.StandardControls;

public partial class CheckBoxAndRadioButton : Window
{
    public CheckBoxAndRadioButton()
    {
        InitializeComponent();
    }

    void OnMakeTea(object sender, RoutedEventArgs e)
    {
        var sb = new StringBuilder("Tea: ");
        foreach (RadioButton rb in _teaTypePanel.Children)
        {
            if (rb.IsChecked == true)
            {
                sb.AppendLine(rb.Content.ToString());
                break;
            }
        }

        if (_isSugar.IsChecked == true) sb.AppendLine("With Sugar");
        if (_isMilk.IsChecked == true) sb.AppendLine("With milk");
        if (_isLemon.IsChecked == true) sb.AppendLine("With lemon");
        if (_isLemon.IsChecked == true && _isMilk.IsChecked == true) sb.AppendLine("Very unusual!");
        MessageBox.Show(sb.ToString(), "Tea Maker");
    }
}