using System.ComponentModel;
using System.Runtime.CompilerServices;
using Dolores.Client.Annotations;
using PropertyChanged;

namespace Dolores.Client.Models
{
	public class PhoneDto : BaseModel
	{		
		#region Properties

		public int Id { get; set; }

		public string Number { get; set; }

		#endregion

	}
}