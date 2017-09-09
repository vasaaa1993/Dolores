using System.Data.Entity.Migrations;
using System.Linq;

namespace Dolores.DbAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Dolores.DbAccess.EF.DoloresDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF.DoloresDbContext context)
        {
			if (!context.Clients.Any())
			{
				//Client client = new Client()
				//{
				//	FirstName = "Vasyl",
				//	SecondName = "Barna",
				//	Phones = new List<Phone>()
				//{
				//	new Phone()
				//	{
				//		Number = "5464313544654"
				//	},
				//	new Phone()
				//	{
				//		Number = "asdassdfsdfdsf"
				//	}
				//},
				//	Equipment = new Equipment()
				//	{
				//		Name = "Котел",
				//		Params = new List<EquimpentParam>()
				//	{
				//		new EquimpentParam()
				//		{
				//			Name = "Фото",
				//			Path = "path"
				//		}
				//	}
				//	}
				//};
				//context.Clients.Add(client);
				//context.SaveChanges();
			}
		}
    }
}
