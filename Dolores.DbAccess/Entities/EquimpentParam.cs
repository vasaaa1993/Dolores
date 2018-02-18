using Dolores.DbAccess.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dolores.DbAccess.Entities
{
	[Table("Equimpent")]
	public class EquimpentParamE: IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Path { get; set; }
		//public virtual Equipment Equipment { get; set; }
		public virtual ClientE Client { get; set; }
	}
}
