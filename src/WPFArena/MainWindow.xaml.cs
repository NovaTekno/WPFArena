using System.Windows;
using WPFArena.LayoutAndPanels;
using WPFArena.StandardControls;

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
        
        private void CanvasDemo2_Click(object sender, RoutedEventArgs e)
        {
            PaintingCircles paintingCircles = new PaintingCircles();
            paintingCircles.Show();
        }
        
        private void TabbedUI_Click(object sender, RoutedEventArgs e)
        {
            TabbedUI tabbedUi = new TabbedUI();
            tabbedUi.Show();
        }
        
        private void DynamicTabbedUI_Click(object sender, RoutedEventArgs e)
        {
            DynamicTabConstruction dynamicTabbedUi = new DynamicTabConstruction();
            dynamicTabbedUi.Show();
        }
        
        private void DragAndDropDemo_Click(object sender, RoutedEventArgs e)
        {
            DragAndDropDemo dragAndDrop = new DragAndDropDemo();
            dragAndDrop.Show();
        }
        
        private void TextBoxDemo1_Click(object sender, RoutedEventArgs e)
        {
            TextControlDemo textControlDemo = new TextControlDemo();
            textControlDemo.Show();
        }
        
        private void ContentControlDemo_Click(object sender, RoutedEventArgs e)
        {
            ContentControlDemo contentControlDemo = new ContentControlDemo();
            contentControlDemo.Show();
        }
        
        private void HeaderedContentControlDemo_Click(object sender, RoutedEventArgs e)
        {
            HeaderedContentControl headeredContentControlDemo = new HeaderedContentControl();
            headeredContentControlDemo.Show();
        }
        
        private void ImagesDemo_Click(object sender, RoutedEventArgs e)
        {
            ImagesDemo imagesDemo = new ImagesDemo();
            imagesDemo.Show();
        }
    }
}