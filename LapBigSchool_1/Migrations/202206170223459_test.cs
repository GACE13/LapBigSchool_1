namespace LapBigSchool_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "LecturerId_Id", newName: "LecturerId");
            RenameIndex(table: "dbo.Courses", name: "IX_LecturerId_Id", newName: "IX_LecturerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_LecturerId", newName: "IX_LecturerId_Id");
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "LecturerId_Id");
        }
    }
}
