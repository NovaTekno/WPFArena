using System.Diagnostics;
using System.Windows;

namespace DialogBoxDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public App()
        {
            Debug.WriteLine("App constructor called!");
            //Method1();
        }
        
        protected void Application_OnStartup(object sender, StartupEventArgs e)
        {
            string text = "Hello, default!";
            if (e.Args.Length > 0)
                text = e.Args[0];
        
            var win = new MainWindow(text);
            win.Show();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }

        /*protected override void Method1()
        {
            Debug.WriteLine("App::Method1 hit!");
            base.Method1();
        }*/
    }
}