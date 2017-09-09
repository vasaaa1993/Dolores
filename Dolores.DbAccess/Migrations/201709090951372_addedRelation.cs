namespace Dolores.DbAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Equipment_Id", "dbo.Equipments");
            DropForeignKey("dbo.Phones", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.EquimpentParams", "Equipment_Id", "dbo.Equipments");
            DropIndex("dbo.Clients", new[] { "Equipment_Id" });
            DropIndex("dbo.EquimpentParams", new[] { "Equipment_Id" });
            DropIndex("dbo.Phones", new[] { "Client_Id" });
            AlterColumn("dbo.Clients", "Equipment_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.EquimpentParams", "Equipment_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Phones", "Client_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "Equipment_Id");
            CreateIndex("dbo.EquimpentParams", "Equipment_Id");
            CreateIndex("dbo.Phones", "Client_Id");
            AddForeignKey("dbo.Clients", "Equipment_Id", "dbo.Equipments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Phones", "Client_Id", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EquimpentParams", "Equipment_Id", "dbo.Equipments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EquimpentParams", "Equipment_Id", "dbo.Equipments");
            DropForeignKey("dbo.Phones", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Clients", "Equipment_Id", "dbo.Equipments");
            DropIndex("dbo.Phones", new[] { "Client_Id" });
            DropIndex("dbo.EquimpentParams", new[] { "Equipment_Id" });
            DropIndex("dbo.Clients", new[] { "Equipment_Id" });
            AlterColumn("dbo.Phones", "Client_Id", c => c.Int());
            AlterColumn("dbo.EquimpentParams", "Equipment_Id", c => c.Int());
            AlterColumn("dbo.Clients", "Equipment_Id", c => c.Int());
            CreateIndex("dbo.Phones", "Client_Id");
            CreateIndex("dbo.EquimpentParams", "Equipment_Id");
            CreateIndex("dbo.Clients", "Equipment_Id");
            AddForeignKey("dbo.EquimpentParams", "Equipment_Id", "dbo.Equipments", "Id");
            AddForeignKey("dbo.Phones", "Client_Id", "dbo.Clients", "Id");
            AddForeignKey("dbo.Clients", "Equipment_Id", "dbo.Equipments", "Id");
        }
    }
}
