using System.Windows;
using WPFArena.LayoutAndPanels;

namespace WPFArena
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void layoutAndPanels_Click(object sender, RoutedEventArgs e)
        {
            GridDemo gridDemo = new GridDemo();
            gridDemo.Show();
        }
    }
}