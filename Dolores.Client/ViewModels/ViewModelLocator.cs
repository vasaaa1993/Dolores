/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Dolores.Client"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using Dolores.Client.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Dolores.Client.ViewModels
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
   //         ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			//////if (ViewModelBase.IsInDesignModeStatic)
			//////{
			//////    // Create design time view services and models
			//////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
			//////}
			//////else
			//////{
			//////    // Create run time view services and models
			//////    SimpleIoc.Default.Register<IDataService, DataService>();
			//////}


			////Views
			//SimpleIoc.Default.Register<ClientView>();
			//SimpleIoc.Default.Register<ClientsListView>();
			//SimpleIoc.Default.Register<MainWindow>();

			//// View Models
   //         SimpleIoc.Default.Register<MainWindowViewModel>();
			//SimpleIoc.Default.Register<ClientsListViewModel>();
			//SimpleIoc.Default.Register<ClientViewModel>();
        }

        public MainWindowViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainWindowViewModel>();
            }
        }

		public ClientsListViewModel ClientsList
		{
			get
			{
				return ServiceLocator.Current.GetInstance<ClientsListViewModel>();
			}
		}

		public ClientViewModel Client
		{
			get
			{
				return ServiceLocator.Current.GetInstance<ClientViewModel>();
			}
		}

		public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}