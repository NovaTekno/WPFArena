using System.Diagnostics;
using System.Windows;

namespace DialogBoxDemo;

public class ApplicationBase : System.Windows.Application
{
    public ApplicationBase()
    {
        Debug.WriteLine("Application base class hit!");
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        Debug.WriteLine("ApplicationBase::OnStartup hit!");
    }

    protected virtual void Application_OnStartup(object sender, StartupEventArgs e)
    {
        Debug.WriteLine("ApplicationBase::Application_OnStartup hit!!");
    }

    protected virtual void Method1()
    {
        Debug.WriteLine("ApplicaationBase::Method1 hit!");
    }
}