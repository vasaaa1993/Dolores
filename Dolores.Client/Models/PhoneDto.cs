using System.ComponentModel;
using System.Runtime.CompilerServices;
using Dolores.Client.Annotations;
using PropertyChanged;

namespace Dolores.Client.Models
{
	class PhoneDto : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		
		#region Properties

		public int Id { get; set; }

		public string Number { get; set; }

		#endregion

	}
}