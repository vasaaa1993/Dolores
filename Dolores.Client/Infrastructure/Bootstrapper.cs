using System.Windows;
using Caliburn.Micro;
using Dolores.Client.ViewModels;

namespace Dolores.Client.Infrastructure
{
    class Bootstrapper: BootstrapperBase
    {
	    public Bootstrapper()
	    {
		    Initialize();
	    }

	    protected override void OnStartup(object sender, StartupEventArgs e)
	    {
		   //DisplayRootViewFor<ShellViewModel>();
	    }
    }
}
