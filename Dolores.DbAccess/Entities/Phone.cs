using Dolores.DbAccess.Interfaces;

namespace Dolores.DbAccess.Entities
{
	class Phone:IEntity
	{
		public int Id { get; set; }
		public string Number { get; set; }
	}
}
