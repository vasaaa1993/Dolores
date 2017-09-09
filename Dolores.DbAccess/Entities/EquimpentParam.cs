using Dolores.DbAccess.Interfaces;

namespace Dolores.DbAccess.Entities
{
	class EquimpentParam: IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Path { get; set; }
		public virtual Equipment Equipment { get; set; }
	}
}
