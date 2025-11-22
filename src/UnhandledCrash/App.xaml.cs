using System;
using System.Windows;
using System.Windows.Threading;

namespace UnhandledCrash
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DispatcherUnhandledException += OnUnhandledException;
        }

        void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error encountered! Please contact support." + Environment.NewLine + e.Exception.Message);
            Shutdown(1);
            e.Handled = true;
        }
    }
}