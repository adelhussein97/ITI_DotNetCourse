
using Lab3_LINQCodeFirst.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Text;

namespace Lab3_LINQCodeFirst
{
    class ITIContext : DbContext
    {
        public ITIContext() : base(@"Data Source=ADELHUSSEIN\SMARTCODERS;Initial Catalog=ITI_Courses;Integrated Security=True")
        {

        }

        // Fluent API Configuration instead of Data Anotations
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");// or new schema ("ITI")
            #region Fluent API Key PK Key
            modelBuilder.Entity<Instructor>().HasKey(i => i.Ins_Id);
            modelBuilder.Entity<Course>().HasKey(c => c.Crs_Id);
            modelBuilder.Entity<Department>().HasKey(d => d.Dept_Id);
            modelBuilder.Entity<Student>().HasKey(s => s.Std_ID);
            modelBuilder.Entity<Topic>().HasKey(t => t.Top_ID);
            #endregion

            #region Fluent API Composite PK
            modelBuilder.Entity<Ins_Course>().HasKey(i => new { i.Crs_Id, i.Ins_Id });
            modelBuilder.Entity<Stud_Course>().HasKey(s => new { s.Crs_Id, s.St_Id });
            #endregion

            #region Fluent API turn off Identity for Primary Keys
            modelBuilder.Entity<Student>().Property(s => s.Std_ID)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Course>().Property(c => c.Crs_Id)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Department>().Property(d => d.Dept_Id)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Instructor>().Property(i => i.Ins_Id)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            #endregion

            #region Fluent API Max Length
            modelBuilder.Entity<Student>().Property(s => s.St_Fname).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.St_Lname).HasMaxLength(50);
            #endregion

            #region Fluent API Map 1 - 1 Relation
            modelBuilder.Entity<Department>()
                .HasRequired(d => d.InstructorMgr)
                .WithOptional(t => t.Department);
            #endregion

            #region Fluent API 1 - M
            //modelBuilder.Entity<Instructor>()
            //            .HasRequired(t => t.Department)
            //            .WithMany(t => t.listInstructors)
            //            .HasForeignKey(d => d.Dno)
            //            .WillCascadeOnDelete(false);
            #endregion

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Ins_Course> Ins_Course { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
