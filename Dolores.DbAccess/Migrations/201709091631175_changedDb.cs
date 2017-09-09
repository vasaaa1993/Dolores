namespace Dolores.DbAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EquimpentParams", "Equipment_Id", "dbo.Equipments");
            DropForeignKey("dbo.Clients", "Equipment_Id", "dbo.Equipments");
            DropIndex("dbo.Clients", new[] { "Equipment_Id" });
            DropIndex("dbo.EquimpentParams", new[] { "Equipment_Id" });
            AddColumn("dbo.EquimpentParams", "Client_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.EquimpentParams", "Client_Id");
            AddForeignKey("dbo.EquimpentParams", "Client_Id", "dbo.Clients", "Id", cascadeDelete: true);
            DropColumn("dbo.Clients", "Equipment_Id");
            DropColumn("dbo.EquimpentParams", "Equipment_Id");
            DropTable("dbo.Equipments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.EquimpentParams", "Equipment_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "Equipment_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.EquimpentParams", "Client_Id", "dbo.Clients");
            DropIndex("dbo.EquimpentParams", new[] { "Client_Id" });
            DropColumn("dbo.EquimpentParams", "Client_Id");
            CreateIndex("dbo.EquimpentParams", "Equipment_Id");
            CreateIndex("dbo.Clients", "Equipment_Id");
            AddForeignKey("dbo.Clients", "Equipment_Id", "dbo.Equipments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EquimpentParams", "Equipment_Id", "dbo.Equipments", "Id", cascadeDelete: true);
        }
    }
}
