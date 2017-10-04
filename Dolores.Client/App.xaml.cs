using System.Windows;
using Ninject;
using Dolores.Client.Views;

namespace Dolores.Client
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private IKernel container;

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			ConfigureContainer();
			ComposeObjects();
			Current.MainWindow.Show();
		}

		private void ConfigureContainer()
		{
			this.container = new StandardKernel();
			container.Bind<MainWindow>().ToSelf();
		}

		private void ComposeObjects()
		{
			Current.MainWindow =  container.Get<MainWindow>();
		}
	}
}
