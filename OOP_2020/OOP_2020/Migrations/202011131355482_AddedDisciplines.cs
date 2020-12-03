namespace OOP_2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDisciplines : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        SpecialityId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.SpecialityId);
            
            CreateTable(
                "dbo.Disciplines",
                c => new
                    {
                        DisciplineId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.DisciplineId);
            
            CreateTable(
                "dbo.DisciplineSpecialities",
                c => new
                    {
                        Discipline_DisciplineId = c.Int(nullable: false),
                        Speciality_SpecialityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Discipline_DisciplineId, t.Speciality_SpecialityId })
                .ForeignKey("dbo.Disciplines", t => t.Discipline_DisciplineId, cascadeDelete: true)
                .ForeignKey("dbo.Specialities", t => t.Speciality_SpecialityId, cascadeDelete: true)
                .Index(t => t.Discipline_DisciplineId)
                .Index(t => t.Speciality_SpecialityId);
            
            AddColumn("dbo.Groups", "SpecialityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Groups", "SpecialityId");
            AddForeignKey("dbo.Groups", "SpecialityId", "dbo.Specialities", "SpecialityId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "SpecialityId", "dbo.Specialities");
            DropForeignKey("dbo.DisciplineSpecialities", "Speciality_SpecialityId", "dbo.Specialities");
            DropForeignKey("dbo.DisciplineSpecialities", "Discipline_DisciplineId", "dbo.Disciplines");
            DropIndex("dbo.DisciplineSpecialities", new[] { "Speciality_SpecialityId" });
            DropIndex("dbo.DisciplineSpecialities", new[] { "Discipline_DisciplineId" });
            DropIndex("dbo.Groups", new[] { "SpecialityId" });
            DropColumn("dbo.Groups", "SpecialityId");
            DropTable("dbo.DisciplineSpecialities");
            DropTable("dbo.Disciplines");
            DropTable("dbo.Specialities");
        }
    }
}
