using System.Windows.Controls;
using System.Windows.Input;
using Dolores.Client.Commands;
using Dolores.Client.Views;
using Dolores.Client.Views.Common;
using GalaSoft.MvvmLight.Messaging;
using Dolores.Client.Messanges;

namespace Dolores.Client.ViewModels
{
	public class MainWindowViewModel : BaseViewModel
	{
		private readonly ClientsListView _clientsListView;
		private readonly ClientView _clientView;

		public Page CurrentPage { get; set; }

		public ICommand ToClientsListView => new RelayCommandWithoutParam(NavigateToClientsList);

		public ICommand ToClientView => new RelayCommandWithoutParam(NavigateToClient);

		public ICommand ShowSelectFolderDlg => new RelayCommandWithoutParam(ShowSelectFolder);



		public MainWindowViewModel(ClientsListView clientsListView, ClientView clientView)
		{
			_clientsListView = clientsListView;
			_clientView = clientView;
			RegisterMessages();
			NavigateToClientsList();
		}


		private void RegisterMessages()
		{
			Messenger.Default.Register<SelectClientMsg>(this, (msg) =>
			{
				NavigateToClient();
			});
		}

		public void NavigateToClientsList()
		{
			CurrentPage = _clientsListView;
		}

		public void ShowSelectFolder()
		{
			SelectFolder selectFolder = new SelectFolder();
			selectFolder.ShowDialog();
		}

		public void NavigateToClient()
		{
			CurrentPage = _clientView;
		}
	}

}
