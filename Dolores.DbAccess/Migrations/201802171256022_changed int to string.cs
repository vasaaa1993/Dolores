namespace Dolores.DbAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedinttostring : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clients", newName: "ClientEs");
            RenameTable(name: "dbo.EquimpentParams", newName: "EquimpentParamEs");
            RenameTable(name: "dbo.Phones", newName: "PhoneEs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.PhoneEs", newName: "Phones");
            RenameTable(name: "dbo.EquimpentParamEs", newName: "EquimpentParams");
            RenameTable(name: "dbo.ClientEs", newName: "Clients");
        }
    }
}
