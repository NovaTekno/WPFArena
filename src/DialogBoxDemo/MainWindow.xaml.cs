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

namespace DialogBoxDemo
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

        public MainWindow(string textCaption)
        {
            InitializeComponent();
            this.Title = textCaption;
        }

        private void OnEnterData(object sender, RoutedEventArgs e)
        {
            var dlg = new DetailsDialog();
            if (dlg.ShowDialog() == true)
            {
                _text.Text = string.Format("Hi, {0}! I see you live in {1}.", dlg.FullName, dlg.City);
            }
        }
    }
}