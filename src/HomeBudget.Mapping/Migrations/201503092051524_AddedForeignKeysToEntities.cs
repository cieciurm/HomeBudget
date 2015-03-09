namespace HomeBudget.Mapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeysToEntities : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Budgets", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Expenses", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Budgets", new[] { "User_Id" });
            DropIndex("dbo.Expenses", new[] { "Category_Id" });
            RenameColumn(table: "dbo.Budgets", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.Expenses", name: "Category_Id", newName: "CategoryId");
            AddColumn("dbo.Expenses", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Budgets", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Expenses", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Budgets", "UserId");
            CreateIndex("dbo.Expenses", "UserId");
            CreateIndex("dbo.Expenses", "CategoryId");
            AddForeignKey("dbo.Expenses", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Budgets", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Expenses", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Budgets", "UserId", "dbo.Users");
            DropForeignKey("dbo.Expenses", "UserId", "dbo.Users");
            DropIndex("dbo.Expenses", new[] { "CategoryId" });
            DropIndex("dbo.Expenses", new[] { "UserId" });
            DropIndex("dbo.Budgets", new[] { "UserId" });
            AlterColumn("dbo.Expenses", "CategoryId", c => c.Int());
            AlterColumn("dbo.Budgets", "UserId", c => c.Int());
            DropColumn("dbo.Expenses", "UserId");
            RenameColumn(table: "dbo.Expenses", name: "CategoryId", newName: "Category_Id");
            RenameColumn(table: "dbo.Budgets", name: "UserId", newName: "User_Id");
            CreateIndex("dbo.Expenses", "Category_Id");
            CreateIndex("dbo.Budgets", "User_Id");
            AddForeignKey("dbo.Expenses", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Budgets", "User_Id", "dbo.Users", "Id");
        }
    }
}
