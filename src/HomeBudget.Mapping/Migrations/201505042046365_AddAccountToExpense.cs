namespace HomeBudget.Mapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountToExpense : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Expenses", "UserId", "dbo.Users");
            DropIndex("dbo.Expenses", new[] { "UserId" });
            AddColumn("dbo.Expenses", "AccountId", c => c.Int(nullable: false));
            CreateIndex("dbo.Expenses", "AccountId");
            AddForeignKey("dbo.Expenses", "AccountId", "dbo.Accounts", "Id", cascadeDelete: true);
            DropColumn("dbo.Expenses", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Expenses", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Expenses", "AccountId", "dbo.Accounts");
            DropIndex("dbo.Expenses", new[] { "AccountId" });
            DropColumn("dbo.Expenses", "AccountId");
            CreateIndex("dbo.Expenses", "UserId");
            AddForeignKey("dbo.Expenses", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
