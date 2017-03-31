namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T_Ports", "Posts", c => c.String());
            DropColumn("dbo.T_Ports", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.T_Ports", "Content", c => c.String());
            DropColumn("dbo.T_Ports", "Posts");
        }
    }
}
