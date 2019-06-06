namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editproductTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.Products", "Tags", c => c.String());
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Desciption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Desciption", c => c.String(maxLength: 500));
            DropColumn("dbo.Products", "Quantity");
            DropColumn("dbo.Products", "Tags");
            DropColumn("dbo.Products", "Description");
        }
    }
}
