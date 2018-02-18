using Dolores.DbAccess.Entities;
using System;

namespace Dolores.Client.Models
{
	public class PhoneDto : BaseModel, ICloneable
	{		
		#region Properties

		public int Id { get; set; }

		public string Number { get; set; }

		public object Clone()
		{
			return MemberwiseClone();
		}

		#endregion

	}


	public static class PhoneExtentions
	{
		public static PhoneE ToDbModel(this PhoneDto phone)
		{
			if (phone == null)
				return null;
			return new PhoneE()
			{
				Id = phone.Id,
				Number = phone.Number
			};
		}
		public static PhoneDto ToModel(this PhoneE phone)
		{
			if (phone == null)
				return null;
			return new PhoneDto()
			{
				Id = phone.Id,
				Number = phone.Number
			};
		}
	}
}