using System.ComponentModel;
using System.Runtime.CompilerServices;
using Dolores.Client.Annotations;

namespace Dolores.Client.Models
{
	public class EquipmentParamDto: BaseModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Path { get; set; }
	}
}
