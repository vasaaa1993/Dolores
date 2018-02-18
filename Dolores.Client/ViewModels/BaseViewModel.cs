using System.ComponentModel;
using System.Runtime.CompilerServices;
using Dolores.Client.Annotations;
using Dolores.DbAccess.Interfaces;
using Dolores.DbAccess.Access;

namespace Dolores.Client.ViewModels
{
	public class BaseViewModel: INotifyPropertyChanged
	{
		protected IUnitOfWork _unitOfWork;

		public event PropertyChangedEventHandler PropertyChanged;

		public BaseViewModel()
		{
			_unitOfWork = new UnitOfWork();
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
