using Dolores.DbAccess.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dolores.DbAccess.Entities
{
	[Table("Phones")]
	public class PhoneE:IEntity
	{
		public int Id { get; set; }
		public string Number { get; set; }

		public virtual ClientE Client { get; set; }
	}
}
