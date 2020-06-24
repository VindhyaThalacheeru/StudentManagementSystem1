namespace StudentCourseRegistrationFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Courses : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CourseModels", "CourseName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.CourseModels", "CourseDetail", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.CourseModels", "Duration", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.CourseModels", "Fees", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CourseModels", "Fees", c => c.String());
            AlterColumn("dbo.CourseModels", "Duration", c => c.String());
            AlterColumn("dbo.CourseModels", "CourseDetail", c => c.String());
            AlterColumn("dbo.CourseModels", "CourseName", c => c.String());
        }
    }
}
