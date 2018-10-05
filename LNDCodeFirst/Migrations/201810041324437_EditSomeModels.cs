namespace LNDCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditSomeModels : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CompanyFieldOfActivities", name: "Company_Id", newName: "CompanyId");
            RenameColumn(table: "dbo.CompanyFieldOfActivities", name: "FieldOfActivity_Id", newName: "FieldOfActivityId");
            RenameIndex(table: "dbo.CompanyFieldOfActivities", name: "IX_Company_Id", newName: "IX_CompanyId");
            RenameIndex(table: "dbo.CompanyFieldOfActivities", name: "IX_FieldOfActivity_Id", newName: "IX_FieldOfActivityId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CompanyFieldOfActivities", name: "IX_FieldOfActivityId", newName: "IX_FieldOfActivity_Id");
            RenameIndex(table: "dbo.CompanyFieldOfActivities", name: "IX_CompanyId", newName: "IX_Company_Id");
            RenameColumn(table: "dbo.CompanyFieldOfActivities", name: "FieldOfActivityId", newName: "FieldOfActivity_Id");
            RenameColumn(table: "dbo.CompanyFieldOfActivities", name: "CompanyId", newName: "Company_Id");
        }
    }
}
