using System;

namespace Dolores.Client.Models
{
	public class EquipmentParamDto: BaseModel, ICloneable
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Path { get; set; }

		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}
