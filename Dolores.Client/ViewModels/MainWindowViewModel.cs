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


	    public MainWindowViewModel()
	    {
		    _clientView = new ClientView();
		    _clientsListView = new ClientsListView();
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


	    public event PropertyChangedEventHandler PropertyChanged;
    }

}
