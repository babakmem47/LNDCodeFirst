namespace LNDCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Persons");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Persons", newName: "People");
        }
    }
}
