namespace Lab3_LINQCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFluentApi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Instructors", "Dno", "dbo.Departments");
            DropForeignKey("dbo.Instructors", "Department_Dept_Id", "dbo.Departments");
            DropForeignKey("dbo.Students", "Dept_ID", "dbo.Departments");
            DropIndex("dbo.Instructors", new[] { "Dno" });
            DropIndex("dbo.Departments", new[] { "Dept_Manager" });
            DropColumn("dbo.Departments", "Dept_Id");
            DropColumn("dbo.Departments", "Dept_Id");
            RenameColumn(table: "dbo.Departments", name: "Dno", newName: "Dept_Id");
            RenameColumn(table: "dbo.Departments", name: "Dept_Manager", newName: "Dept_Id");
            DropPrimaryKey("dbo.Departments");
            AlterColumn("dbo.Departments", "Dept_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Departments", "Dept_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Departments", "Dept_Id");
            CreateIndex("dbo.Departments", "Dept_Id");
            AddForeignKey("dbo.Departments", "Dept_Id", "dbo.Instructors", "Ins_Id");
            AddForeignKey("dbo.Instructors", "Department_Dept_Id", "dbo.Departments", "Dept_Id");
            AddForeignKey("dbo.Students", "Dept_ID", "dbo.Departments", "Dept_Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Students", "Dept_ID", "dbo.Departments");
            DropForeignKey("dbo.Instructors", "Department_Dept_Id", "dbo.Departments");
            DropForeignKey("dbo.Departments", "Dept_Id", "dbo.Instructors");
            DropIndex("dbo.Departments", new[] { "Dept_Id" });
            DropPrimaryKey("dbo.Departments");
            AlterColumn("dbo.Departments", "Dept_Id", c => c.Int());
            AlterColumn("dbo.Departments", "Dept_Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Departments", "Dept_Id");
            RenameColumn(table: "dbo.Departments", name: "Dept_Id", newName: "Dept_Manager");
            RenameColumn(table: "dbo.Departments", name: "Dept_Id", newName: "Dno");
            AddColumn("dbo.Departments", "Dept_Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Departments", "Dept_Id", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.Departments", "Dept_Manager");
            CreateIndex("dbo.Instructors", "Dno");
            AddForeignKey("dbo.Students", "Dept_ID", "dbo.Departments", "Dept_Id", cascadeDelete: true);
            AddForeignKey("dbo.Instructors", "Department_Dept_Id", "dbo.Departments", "Dept_Id");
            AddForeignKey("dbo.Instructors", "Dno", "dbo.Departments", "Dept_Id", cascadeDelete: true);
        }
    }
}
