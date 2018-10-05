namespace LNDCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNameInCompanyRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FieldOfActivities", "Name", c => c.String(nullable: false, maxLength: 70));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FieldOfActivities", "Name", c => c.String());
        }
    }
}
