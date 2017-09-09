namespace Dolores.DbAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        Distance = c.Int(nullable: false),
                        Email = c.String(),
                        Region = c.String(),
                        District = c.String(),
                        Town = c.String(),
                        Street = c.String(),
                        Building = c.String(),
                        Apartment = c.String(),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        MiddleName = c.String(),
                        LastContactTime = c.DateTime(nullable: false),
                        DateOfContract = c.DateTime(nullable: false),
                        GasSealNumber = c.Int(nullable: false),
                        GasServiceContractNumber = c.Int(nullable: false),
                        ContractNumber = c.Int(nullable: false),
                        Description = c.String(),
                        Equipment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipments", t => t.Equipment_Id)
                .Index(t => t.Equipment_Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EquimpentParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Path = c.String(),
                        Equipment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipments", t => t.Equipment_Id)
                .Index(t => t.Equipment_Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Clients", "Equipment_Id", "dbo.Equipments");
            DropForeignKey("dbo.EquimpentParams", "Equipment_Id", "dbo.Equipments");
            DropIndex("dbo.Phones", new[] { "Client_Id" });
            DropIndex("dbo.EquimpentParams", new[] { "Equipment_Id" });
            DropIndex("dbo.Clients", new[] { "Equipment_Id" });
            DropTable("dbo.Phones");
            DropTable("dbo.EquimpentParams");
            DropTable("dbo.Equipments");
            DropTable("dbo.Clients");
        }
    }
}
