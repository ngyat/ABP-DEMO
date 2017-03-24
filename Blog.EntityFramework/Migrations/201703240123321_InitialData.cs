namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialData : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.T_Port", newName: "T_Ports");
            RenameTable(name: "dbo.T_Tag", newName: "T_Tags");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.T_Tags", newName: "T_Tag");
            RenameTable(name: "dbo.T_Ports", newName: "T_Port");
        }
    }
}
