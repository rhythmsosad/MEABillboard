namespace MEABillboardWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthUserGroups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        FunctionName = c.String(),
                        UserGroupName = c.String(),
                        UserCount = c.Int(nullable: false),
                        AllNameList = c.String(),
                        NameList = c.String(),
                        FunctionList = c.String(),
                        Function = c.String(),
                        AllName = c.String(),
                        UserInGroup = c.String(),
                    })
                .PrimaryKey(t => t.GroupId);
            
            CreateTable(
                "dbo.AuthUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Position = c.String(),
                        Branch = c.Int(nullable: false),
                        Email = c.String(),
                        Mobile = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Active = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AuthUsers");
            DropTable("dbo.AuthUserGroups");
        }
    }
}
