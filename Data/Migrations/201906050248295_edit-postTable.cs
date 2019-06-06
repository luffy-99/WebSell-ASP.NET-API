namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editpostTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.OrderDetails", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "Name", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.PostCategories", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.OrderDetails", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.OrderDetails", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 256));
            DropColumn("dbo.OrderDetails", "UpdateDate");
            DropColumn("dbo.OrderDetails", "UpdateBy");
            DropColumn("dbo.Products", "UpdateDate");
            DropColumn("dbo.Products", "UpdateBy");
            DropColumn("dbo.ProductCategories", "UpdateDate");
            DropColumn("dbo.ProductCategories", "UpdateBy");
            DropColumn("dbo.Pages", "UpdateDate");
            DropColumn("dbo.Pages", "UpdateBy");
            DropColumn("dbo.PostCategories", "UpdateDate");
            DropColumn("dbo.PostCategories", "UpdateBy");
            DropColumn("dbo.Posts", "UpdateDate");
            DropColumn("dbo.Posts", "UpdateBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "UpdateBy", c => c.String());
            AddColumn("dbo.Posts", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdateBy", c => c.String());
            AddColumn("dbo.PostCategories", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdateBy", c => c.String());
            AddColumn("dbo.Pages", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "UpdateBy", c => c.String());
            AddColumn("dbo.ProductCategories", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdateBy", c => c.String());
            AddColumn("dbo.Products", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.OrderDetails", "UpdateBy", c => c.String());
            AddColumn("dbo.OrderDetails", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Posts", "MetaDescription", c => c.String());
            AlterColumn("dbo.Posts", "MetaKeyword", c => c.String());
            AlterColumn("dbo.PostCategories", "MetaDescription", c => c.String());
            AlterColumn("dbo.PostCategories", "MetaKeyword", c => c.String());
            AlterColumn("dbo.Pages", "MetaDescription", c => c.String());
            AlterColumn("dbo.Pages", "MetaKeyword", c => c.String());
            AlterColumn("dbo.ProductCategories", "MetaDescription", c => c.String());
            AlterColumn("dbo.ProductCategories", "MetaKeyword", c => c.String());
            AlterColumn("dbo.Products", "MetaDescription", c => c.String());
            AlterColumn("dbo.Products", "MetaKeyword", c => c.String());
            AlterColumn("dbo.OrderDetails", "MetaDescription", c => c.String());
            AlterColumn("dbo.OrderDetails", "MetaKeyword", c => c.String());
            DropColumn("dbo.Posts", "UpdatedBy");
            DropColumn("dbo.Posts", "UpdatedDate");
            DropColumn("dbo.PostCategories", "UpdatedBy");
            DropColumn("dbo.PostCategories", "UpdatedDate");
            DropColumn("dbo.PostCategories", "Name");
            DropColumn("dbo.Pages", "UpdatedBy");
            DropColumn("dbo.Pages", "UpdatedDate");
            DropColumn("dbo.ProductCategories", "UpdatedBy");
            DropColumn("dbo.ProductCategories", "UpdatedDate");
            DropColumn("dbo.Products", "UpdatedBy");
            DropColumn("dbo.Products", "UpdatedDate");
            DropColumn("dbo.OrderDetails", "UpdatedBy");
            DropColumn("dbo.OrderDetails", "UpdatedDate");
        }
    }
}
