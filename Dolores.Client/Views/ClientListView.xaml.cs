using System.Windows.Controls;
using Dolores.Client.ViewModels;

namespace Dolores.Client.Views
{
	/// <summary>
	/// Interaction logic for ClientListView.xaml
	/// </summary>
	public partial class ClientsListView : Page
	{
		public ClientsListView()
		{
			InitializeComponent();
			DataContext = new ClientsListViewModel();
		}
	}
}
