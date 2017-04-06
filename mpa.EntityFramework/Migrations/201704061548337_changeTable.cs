namespace mpa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TasksInfoes", newName: "TasksInfo");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TasksInfo", newName: "TasksInfoes");
        }
    }
}
