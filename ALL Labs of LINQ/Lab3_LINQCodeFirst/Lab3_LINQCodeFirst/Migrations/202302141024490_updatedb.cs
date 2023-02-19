namespace Lab3_LINQCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Instructors", "Department_Dept_Id", "dbo.Departments");
            DropIndex("dbo.Instructors", new[] { "Department_Dept_Id" });
            CreateTable(
                "dbo.DepartmentInstructors",
                c => new
                    {
                        Department_Dept_Id = c.Int(nullable: false),
                        Instructor_Ins_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Department_Dept_Id, t.Instructor_Ins_Id })
                .ForeignKey("dbo.Departments", t => t.Department_Dept_Id, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.Instructor_Ins_Id, cascadeDelete: true)
                .Index(t => t.Department_Dept_Id)
                .Index(t => t.Instructor_Ins_Id);
            
            DropColumn("dbo.Instructors", "Department_Dept_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instructors", "Department_Dept_Id", c => c.Int());
            DropForeignKey("dbo.DepartmentInstructors", "Instructor_Ins_Id", "dbo.Instructors");
            DropForeignKey("dbo.DepartmentInstructors", "Department_Dept_Id", "dbo.Departments");
            DropIndex("dbo.DepartmentInstructors", new[] { "Instructor_Ins_Id" });
            DropIndex("dbo.DepartmentInstructors", new[] { "Department_Dept_Id" });
            DropTable("dbo.DepartmentInstructors");
            CreateIndex("dbo.Instructors", "Department_Dept_Id");
            AddForeignKey("dbo.Instructors", "Department_Dept_Id", "dbo.Departments", "Dept_Id");
        }
    }
}
