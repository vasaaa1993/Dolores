namespace Dolores.DbAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inttostring : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ClientEs", newName: "Clients");
            RenameTable(name: "dbo.EquimpentParamEs", newName: "Equimpent");
            RenameTable(name: "dbo.PhoneEs", newName: "Phones");
            AlterColumn("dbo.Clients", "GasSealNumber", c => c.String());
            AlterColumn("dbo.Clients", "GasServiceContractNumber", c => c.String());
            AlterColumn("dbo.Clients", "ContractNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "ContractNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "GasServiceContractNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "GasSealNumber", c => c.Int(nullable: false));
            RenameTable(name: "dbo.Phones", newName: "PhoneEs");
            RenameTable(name: "dbo.Equimpent", newName: "EquimpentParamEs");
            RenameTable(name: "dbo.Clients", newName: "ClientEs");
        }
    }
}
