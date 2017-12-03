using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using Dolores.Client.Annotations;
using Dolores.Client.Commands;
using Dolores.Client.Views;
using Dolores.Client.Views.Common;

namespace Dolores.Client.ViewModels
{
    public class MainWindowViewModel: BaseViewModel
	{
		private readonly ClientsListView _clientsListView;
	    private readonly ClientView _clientView;
		
		public Page CurrentPage { get; set; }

		public ICommand ToClientsListView => new RelayCommand(NavigateToClientsList);

	    public ICommand ToClientView => new RelayCommand(NavigateToClient);

		public ICommand ShowSelectFolderDlg => new RelayCommand(ShowSelectFolder);

		

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

		public void ShowSelectFolder(object param)
		{
			SelectFolder selectFolder = new SelectFolder();
			selectFolder.ShowDialog();
		}

	    public void NavigateToClient(object param)
	    {
		    CurrentPage = _clientView;
	    }
	}

}
