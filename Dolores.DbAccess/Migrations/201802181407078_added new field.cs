namespace Dolores.DbAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class addednewfield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "DateOfContractContinuation", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "EquipmentModel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "EquipmentModel");
            DropColumn("dbo.Clients", "DateOfContractContinuation");
        }
    }
}
