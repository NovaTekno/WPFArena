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
        
        private void GridDemo_Click(object sender, RoutedEventArgs e)
        {
            GridDemo gridDemo = new GridDemo();
            gridDemo.Show();
        }
        
        private void DynamicGridSizing_Click(object sender, RoutedEventArgs e)
        {
            DynamicGridSizing dynamicGridSizing = new DynamicGridSizing();
            dynamicGridSizing.Show();
        }
        
        private void ScrollableView_Click(object sender, RoutedEventArgs e)
        {
            ScrollableUI scrollalbeUi = new ScrollableUI();
            scrollalbeUi.Show();
        }
        
        private void BorderDemo_Click(object sender, RoutedEventArgs e)
        {
            BorderDemo borderDemo = new BorderDemo();
            borderDemo.Show();
        }
        
        private void CanvasDemo_Click(object sender, RoutedEventArgs e)
        {
            CanvasDemo canvasDemo = new CanvasDemo();
            canvasDemo.Show();
        }
    }
}