using System;
using System.Windows;
using Dolores.Client.ViewModels;
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
			SetLanguageDictianary();
			ConfigureContainer();
			ComposeObjects();
			Current.MainWindow.Show();
		}

		private void ConfigureContainer()
		{
			this.container = new StandardKernel();
			container.Bind<MainWindowViewModel>().ToSelf();
			container.Bind<MainWindow>().ToSelf();
			container.Bind<ClientView>().ToSelf();
			container.Bind<ClientsListView>().ToSelf();
			container.Bind<SelectFolderViewModel>().ToSelf();
		}

		private void ComposeObjects()
		{
			Current.MainWindow =  container.Get<MainWindow>();
		}

		private void SetLanguageDictianary()
		{
			ResourceDictionary dict = new ResourceDictionary();
			dict.Source = new Uri("..\\Resources\\Languages\\Default.xaml", UriKind.Relative);
			Resources.MergedDictionaries.Add(dict);
		}
	}
}
