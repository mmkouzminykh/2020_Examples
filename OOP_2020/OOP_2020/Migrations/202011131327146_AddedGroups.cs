namespace OOP_2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGroups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupCode = c.Int(nullable: false, identity: true),
                        GroupName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.GroupCode);
            
            AddColumn("dbo.Humen", "GroupCode", c => c.Int());
            AlterColumn("dbo.Humen", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Humen", "Patronymic", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Humen", "FamilyName", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Humen", "GroupCode");
            AddForeignKey("dbo.Humen", "GroupCode", "dbo.Groups", "GroupCode");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Humen", "GroupCode", "dbo.Groups");
            DropIndex("dbo.Humen", new[] { "GroupCode" });
            AlterColumn("dbo.Humen", "FamilyName", c => c.String());
            AlterColumn("dbo.Humen", "Patronymic", c => c.String());
            AlterColumn("dbo.Humen", "Name", c => c.String());
            DropColumn("dbo.Humen", "GroupCode");
            DropTable("dbo.Groups");
        }
    }
}
