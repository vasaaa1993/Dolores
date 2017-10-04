using Dolores.ClientUwp.ViewModels;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace Dolores.ClientUwp
{
	/// <summary>
	/// This class contains static references to all the view models in the
	/// application and provides an entry point for the bindings.
	/// </summary> 
	public class ViewModelLocator
	{
		/// <summary>
		/// Initializes a new instance of the ViewModelLocator class.
		/// </summary>
		public ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			if (ViewModelBase.IsInDesignModeStatic)
			{
				// Create design time view services and models
			}
			else
			{
				// Create run time view services and models
			}

			//Register your services used here
			SimpleIoc.Default.Register<INavigationService, NavigationService>();

			// Register services 
			
			// Register ViewModels
			SimpleIoc.Default.Register<ClientListViewModel>();
			SimpleIoc.Default.Register<MainViewModel>();
		}

		public ClientListViewModel ClientListVMInstance
		{
			get
			{
				return ServiceLocator.Current.GetInstance<ClientListViewModel>();
			}
		}

		public MainViewModel MainVMInstance
		{
			get
			{
				return ServiceLocator.Current.GetInstance<MainViewModel>();
			}
		}

		//// <summary>
		//// Gets the History view model.
		//// </summary>
		//// <value>
		//// The History view model.
		//// </value>
		//public HistoryViewModel HistoryVMInstance
		//{
		//	get
		//	{
		//		return ServiceLocator.Current.GetInstance<HistoryViewModel>();
		//	}
		//}

		// <summary>
		// The cleanup.
		// </summary>
		public static void Cleanup()
		{
			// TODO Clear the ViewModels
		}
	}

}