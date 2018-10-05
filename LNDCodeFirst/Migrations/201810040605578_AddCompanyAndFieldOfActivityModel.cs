namespace LNDCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyAndFieldOfActivityModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        Address = c.String(maxLength: 200),
                        Email = c.String(),
                        PreTelCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FieldOfActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyFieldOfActivities",
                c => new
                    {
                        Company_Id = c.Int(nullable: false),
                        FieldOfActivity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Company_Id, t.FieldOfActivity_Id })
                .ForeignKey("dbo.Companies", t => t.Company_Id, cascadeDelete: true)
                .ForeignKey("dbo.FieldOfActivities", t => t.FieldOfActivity_Id, cascadeDelete: true)
                .Index(t => t.Company_Id)
                .Index(t => t.FieldOfActivity_Id);
            
            AddColumn("dbo.Persons", "CompanyId", c => c.Int());
            CreateIndex("dbo.Persons", "CompanyId");
            AddForeignKey("dbo.Persons", "CompanyId", "dbo.Companies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persons", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.CompanyFieldOfActivities", "FieldOfActivity_Id", "dbo.FieldOfActivities");
            DropForeignKey("dbo.CompanyFieldOfActivities", "Company_Id", "dbo.Companies");
            DropIndex("dbo.CompanyFieldOfActivities", new[] { "FieldOfActivity_Id" });
            DropIndex("dbo.CompanyFieldOfActivities", new[] { "Company_Id" });
            DropIndex("dbo.Persons", new[] { "CompanyId" });
            DropColumn("dbo.Persons", "CompanyId");
            DropTable("dbo.CompanyFieldOfActivities");
            DropTable("dbo.FieldOfActivities");
            DropTable("dbo.Companies");
        }
    }
}
