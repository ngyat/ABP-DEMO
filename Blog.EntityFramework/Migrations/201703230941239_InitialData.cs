namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_Port",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Article = c.String(),
                        Posts = c.String(),
                        Creator = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Modifier = c.String(),
                        ModifyDateTime = c.DateTime(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                        Views = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_PortTag",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TagId = c.String(maxLength: 128),
                        PortId = c.String(maxLength: 128),
                        Creator = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Modifier = c.String(),
                        ModifyDateTime = c.DateTime(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Port", t => t.PortId)
                .ForeignKey("dbo.T_Tag", t => t.TagId)
                .Index(t => t.TagId)
                .Index(t => t.PortId);
            
            CreateTable(
                "dbo.T_Tag",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Creator = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Modifier = c.String(),
                        ModifyDateTime = c.DateTime(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_RortReply",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ReplyID = c.String(),
                        ReplyUserID = c.String(),
                        Content = c.String(),
                        Creator = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Modifier = c.String(),
                        ModifyDateTime = c.DateTime(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_PortTag", "TagId", "dbo.T_Tag");
            DropForeignKey("dbo.T_PortTag", "PortId", "dbo.T_Port");
            DropIndex("dbo.T_PortTag", new[] { "PortId" });
            DropIndex("dbo.T_PortTag", new[] { "TagId" });
            DropTable("dbo.T_RortReply");
            DropTable("dbo.T_Tag");
            DropTable("dbo.T_PortTag");
            DropTable("dbo.T_Port");
        }
    }
}
