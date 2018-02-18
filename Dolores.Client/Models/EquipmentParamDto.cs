using Dolores.DbAccess.Entities;
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


	public static class EquipmentExtentions
	{
		public static EquimpentParamE ToDbModel(this EquipmentParamDto equipment)
		{
			if (equipment == null)
				return null;

			return new EquimpentParamE()
			{
				Id = equipment.Id,
				Name = equipment.Name,
				Path = equipment.Path
			};
		}

		public static EquipmentParamDto ToModel(this EquimpentParamE equipment)
		{
			if (equipment == null)
				return null;

			return new EquipmentParamDto()
			{
				Id = equipment.Id,
				Name = equipment.Name,
				Path = equipment.Path
			};
		}
	}
		
}
