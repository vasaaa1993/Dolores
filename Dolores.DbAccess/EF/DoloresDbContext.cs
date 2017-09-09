using Dolores.DbAccess.Entities;
using System.Data.Entity;

namespace Dolores.DbAccess.EF
{
	class DoloresDbContext : DbContext
	{
		public DoloresDbContext() : base("DoloresDb") { }

		public DbSet<Client> Clients { get; set; }
		public DbSet<Phone> Phones { get; set; }
		//public DbSet<Equipment> Equipments { get; set; }
		public DbSet<EquimpentParam> EquimpentParams { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Client>().HasRequired(t => t.Equipment);
			modelBuilder.Entity<EquimpentParam>().HasRequired(t => t.Client).WithMany(t => t.Equimpents);
			modelBuilder.Entity<Phone>().HasRequired(t => t.Client).WithMany(t => t.Phones);
			
			base.OnModelCreating(modelBuilder);
		}
	}
}
