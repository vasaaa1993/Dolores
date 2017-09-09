using Dolores.DbAccess.Entities;
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

		public DbSet<Client> Clients { get; set; }
		public DbSet<Phone> Phones { get; set; }
		public DbSet<Equipment> Equipments { get; set; }
		public DbSet<EquimpentParam> EquimpentParams { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
