namespace StudentCourseRegistrationFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Course : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseModels",
                c => new
                    {
                        courseId = c.Int(nullable: false, identity: true),
                        courseName = c.String(),
                        courseDetail = c.String(),
                        duration = c.String(),
                        fees = c.String(),
                    })
                .PrimaryKey(t => t.courseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CourseModels");
        }
    }
}
