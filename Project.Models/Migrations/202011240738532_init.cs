namespace Project.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(nullable: false),
                        BookTitle = c.String(nullable: false),
                        BookDescription = c.String(),
                        Image = c.String(nullable: false),
                        Price = c.Single(nullable: false),
                        Code = c.String(),
                        Create_at = c.DateTime(),
                        Update_at = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        TotalPrice = c.Single(),
                        PaymentMethods = c.String(),
                        Status = c.Byte(nullable: false),
                        Created = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        PassWord = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.Group_GroupId);
            
            CreateTable(
                "dbo.Businesses",
                c => new
                    {
                        BusinessId = c.String(nullable: false, maxLength: 128),
                        BusinessName = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BusinessId);
            
            CreateTable(
                "dbo.GroupRoles",
                c => new
                    {
                        GroupId = c.Int(nullable: false),
                        BusinessId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.GroupId, t.BusinessId, t.RoleId })
                .ForeignKey("dbo.Businesses", t => t.BusinessId, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.BusinessId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        GroupName = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GroupId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        RoleName = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.FeedBackForms",
                c => new
                    {
                        FeedBackId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeedBackId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FeedBackForms", "UserId", "dbo.Users");
            DropForeignKey("dbo.GroupRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "Group_GroupId", "dbo.Groups");
            DropForeignKey("dbo.GroupRoles", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.GroupRoles", "BusinessId", "dbo.Businesses");
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.Books", "UserId", "dbo.Users");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "BookId", "dbo.Books");
            DropIndex("dbo.FeedBackForms", new[] { "UserId" });
            DropIndex("dbo.GroupRoles", new[] { "RoleId" });
            DropIndex("dbo.GroupRoles", new[] { "BusinessId" });
            DropIndex("dbo.GroupRoles", new[] { "GroupId" });
            DropIndex("dbo.Users", new[] { "Group_GroupId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.OrderDetails", new[] { "BookId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Books", new[] { "UserId" });
            DropTable("dbo.FeedBackForms");
            DropTable("dbo.Roles");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupRoles");
            DropTable("dbo.Businesses");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Books");
        }
    }
}
