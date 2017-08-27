using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolores.DbAccess.EF
{
	class DoloresDbContext : DbContext
	{
		public DoloresDbContext() : base("DoloresDb") { }
	}
}
