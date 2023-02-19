namespace Lab3_LINQCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_insDept : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "Department_Dept_Id", c => c.Int());
            AddColumn("dbo.Departments", "Dept_Manager", c => c.Int());
            CreateIndex("dbo.Instructors", "Department_Dept_Id");
            CreateIndex("dbo.Departments", "Dept_Manager");
            AddForeignKey("dbo.Departments", "Dept_Manager", "dbo.Instructors", "Ins_Id");
            AddForeignKey("dbo.Instructors", "Department_Dept_Id", "dbo.Departments", "Dept_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instructors", "Department_Dept_Id", "dbo.Departments");
            DropForeignKey("dbo.Departments", "Dept_Manager", "dbo.Instructors");
            DropIndex("dbo.Departments", new[] { "Dept_Manager" });
            DropIndex("dbo.Instructors", new[] { "Department_Dept_Id" });
            DropColumn("dbo.Departments", "Dept_Manager");
            DropColumn("dbo.Instructors", "Department_Dept_Id");
        }
    }
}
