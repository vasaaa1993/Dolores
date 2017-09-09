using Dolores.DbAccess.Interfaces;
using System.Collections.Generic;

namespace Dolores.DbAccess.Entities
{
	class Equipment : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual ICollection<EquimpentParam> Params { get; set; }
	}
}
