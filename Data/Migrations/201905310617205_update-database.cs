namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Pages", "MetaKeyWord", c => c.String());
            AddColumn("dbo.Pages", "MetaDescription", c => c.String());
            AddColumn("dbo.Pages", "UpdateBy", c => c.String());
            AddColumn("dbo.Pages", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "MetaKeyWord", c => c.String());
            AddColumn("dbo.PostCategories", "MetaDescription", c => c.String());
            AddColumn("dbo.PostCategories", "UpdateBy", c => c.String());
            AddColumn("dbo.PostCategories", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Posts", "MetaKeyWord", c => c.String());
            AddColumn("dbo.Posts", "MetaDescription", c => c.String());
            AddColumn("dbo.Posts", "UpdateBy", c => c.String());
            AddColumn("dbo.Posts", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Status");
            DropColumn("dbo.Posts", "UpdateBy");
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "MetaKeyWord");
            DropColumn("dbo.Posts", "UpdateDate");
            DropColumn("dbo.Posts", "CreatedBy");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.PostCategories", "Status");
            DropColumn("dbo.PostCategories", "UpdateBy");
            DropColumn("dbo.PostCategories", "MetaDescription");
            DropColumn("dbo.PostCategories", "MetaKeyWord");
            DropColumn("dbo.PostCategories", "UpdateDate");
            DropColumn("dbo.PostCategories", "CreatedBy");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.Pages", "Status");
            DropColumn("dbo.Pages", "UpdateBy");
            DropColumn("dbo.Pages", "MetaDescription");
            DropColumn("dbo.Pages", "MetaKeyWord");
            DropColumn("dbo.Pages", "UpdateDate");
            DropColumn("dbo.Pages", "CreatedBy");
            DropColumn("dbo.Pages", "CreatedDate");
        }
    }
}
