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
}