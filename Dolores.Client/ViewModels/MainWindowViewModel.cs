using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using Dolores.Client.Commands;
using Dolores.Client.Views;

namespace Dolores.Client.ViewModels
{
    public class MainWindowViewModel: INotifyPropertyChanged  
    {
		private readonly ClientsListView _clientsListView;
	    private readonly ClientView _clientView;

	    public Page CurrentPage { get; set; }

	    public ICommand ToClientsListView => new RelayCommand(NavigateToClientsList);

	    public ICommand ToClientView => new RelayCommand(NavigateToClient);


	    public MainWindowViewModel(ClientsListView clientsListView, ClientView clientView)
	    {
		    _clientsListView = clientsListView;
		    _clientView = clientView;
		    NavigateToClientsList(null);
	    }

		public void NavigateToClientsList(object param)
	    {
		    CurrentPage = _clientsListView;
	    }

	    public void NavigateToClient(object param)
	    {
		    CurrentPage = _clientView;
	    }


		#region UI Events

		private void MenuHome_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
		{
			throw new System.NotImplementedException();
		}

	    private void MenuUserList_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
	    {
		    NavigateToClientsList(null);
	    }

	    private void MenuUser_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
	    {
			NavigateToClient(null);
	    }

	    private void MenuSettings_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
	    {
		    throw new System.NotImplementedException();
	    }
		#endregion

		public event PropertyChangedEventHandler PropertyChanged;
    }

}
