using System;
using System.Windows;
using Dolores.Client.ViewModels;
using Dolores.Client.Views;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Ioc;

namespace Dolores.Client
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			SetLanguageDictianary();
			ConfigureServices();
			ComposeObjects();
			Current.MainWindow.Show();
		}

		private void ConfigureServices()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
			//Views
			SimpleIoc.Default.Register<ClientView>();
			SimpleIoc.Default.Register<ClientsListView>();
			SimpleIoc.Default.Register<MainWindow>();

			// View Models
			SimpleIoc.Default.Register<MainWindowViewModel>();
			SimpleIoc.Default.Register<ClientsListViewModel>();
			SimpleIoc.Default.Register<ClientViewModel>();
		}

		private void ComposeObjects()
		{
			Current.MainWindow =  ServiceLocator.Current.GetInstance<MainWindow>();
		}

		private void SetLanguageDictianary()
		{
			ResourceDictionary dict = new ResourceDictionary();
			dict.Source = new Uri("..\\Resources\\Languages\\Default.xaml", UriKind.Relative);
			Resources.MergedDictionaries.Add(dict);
		}
	}
}
