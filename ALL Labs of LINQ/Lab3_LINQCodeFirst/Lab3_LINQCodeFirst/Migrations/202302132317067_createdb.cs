namespace Lab3_LINQCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Crs_Id = c.Int(nullable: false),
                        Crs_Name = c.String(nullable: false, maxLength: 50),
                        Crs_Duration = c.Int(nullable: false),
                        Topic_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Crs_Id)
                .ForeignKey("dbo.Topics", t => t.Topic_ID, cascadeDelete: true)
                .Index(t => t.Topic_ID);
            
            CreateTable(
                "dbo.Ins_Course",
                c => new
                    {
                        Ins_Id = c.Int(nullable: false),
                        Crs_Id = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                        Evaluation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ins_Id, t.Crs_Id })
                .ForeignKey("dbo.Courses", t => t.Crs_Id, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.Ins_Id, cascadeDelete: true)
                .Index(t => t.Ins_Id)
                .Index(t => t.Crs_Id);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        Ins_Id = c.Int(nullable: false),
                        Ins_Name = c.String(nullable: false, maxLength: 50),
                        Ins_Degree = c.String(),
                        Salary = c.Single(nullable: false),
                        Dno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ins_Id)
                .ForeignKey("dbo.Departments", t => t.Dno, cascadeDelete: true)
                .Index(t => t.Dno);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Dept_Id = c.Int(nullable: false, identity: true),
                        Dept_Name = c.String(nullable: false, maxLength: 50),
                        Dept_Desc = c.String(),
                        Dept_Location = c.String(),
                        Manager_Hiredate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Dept_Id);
            
            CreateTable(
                "dbo.Stud_Course",
                c => new
                    {
                        Crs_Id = c.Int(nullable: false),
                        St_Id = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Crs_Id, t.St_Id })
                .ForeignKey("dbo.Courses", t => t.Crs_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.St_Id, cascadeDelete: true)
                .Index(t => t.Crs_Id)
                .Index(t => t.St_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Std_ID = c.Int(nullable: false),
                        St_Fname = c.String(nullable: false, maxLength: 50),
                        St_Lname = c.String(nullable: false, maxLength: 50),
                        St_Address = c.String(maxLength: 100),
                        St_Age = c.Int(nullable: false),
                        Dept_ID = c.Int(nullable: false),
                        St_Super = c.Int(),
                    })
                .PrimaryKey(t => t.Std_ID)
                .ForeignKey("dbo.Departments", t => t.Dept_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.St_Super)
                .Index(t => t.Dept_ID)
                .Index(t => t.St_Super);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Top_ID = c.Int(nullable: false, identity: true),
                        Top_Name = c.String(),
                    })
                .PrimaryKey(t => t.Top_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Topic_ID", "dbo.Topics");
            DropForeignKey("dbo.Stud_Course", "St_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "St_Super", "dbo.Students");
            DropForeignKey("dbo.Students", "Dept_ID", "dbo.Departments");
            DropForeignKey("dbo.Stud_Course", "Crs_Id", "dbo.Courses");
            DropForeignKey("dbo.Ins_Course", "Ins_Id", "dbo.Instructors");
            DropForeignKey("dbo.Instructors", "Dno", "dbo.Departments");
            DropForeignKey("dbo.Ins_Course", "Crs_Id", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "St_Super" });
            DropIndex("dbo.Students", new[] { "Dept_ID" });
            DropIndex("dbo.Stud_Course", new[] { "St_Id" });
            DropIndex("dbo.Stud_Course", new[] { "Crs_Id" });
            DropIndex("dbo.Instructors", new[] { "Dno" });
            DropIndex("dbo.Ins_Course", new[] { "Crs_Id" });
            DropIndex("dbo.Ins_Course", new[] { "Ins_Id" });
            DropIndex("dbo.Courses", new[] { "Topic_ID" });
            DropTable("dbo.Topics");
            DropTable("dbo.Students");
            DropTable("dbo.Stud_Course");
            DropTable("dbo.Departments");
            DropTable("dbo.Instructors");
            DropTable("dbo.Ins_Course");
            DropTable("dbo.Courses");
        }
    }
}
