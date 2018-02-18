using Dolores.DbAccess.Entities;
using System.Data.Entity;

namespace Dolores.DbAccess.EF
{
	class DoloresDbContext : DbContext
	{
		public DoloresDbContext() : base("DoloresDb") { }

		public DbSet<ClientE> Clients { get; set; }
		public DbSet<PhoneE> Phones { get; set; }
		//public DbSet<Equipment> Equipments { get; set; }
		public DbSet<EquimpentParamE> EquimpentParams { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Client>().HasRequired(t => t.Equipment);
			modelBuilder.Entity<EquimpentParamE>().HasRequired(t => t.Client).WithMany(t => t.Equimpents);
			modelBuilder.Entity<PhoneE>().HasRequired(t => t.Client).WithMany(t => t.Phones);
			
			base.OnModelCreating(modelBuilder);
		}
	}
}
