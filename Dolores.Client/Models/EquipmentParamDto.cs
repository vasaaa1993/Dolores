using System.ComponentModel;
using System.Runtime.CompilerServices;
using Dolores.Client.Annotations;

namespace Dolores.Client.Models
{
	class EquipmentParamDto: INotifyPropertyChanged
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Path { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
