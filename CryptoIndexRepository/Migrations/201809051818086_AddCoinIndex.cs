namespace CryptoIndexRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoinIndex : DbMigration
    {
        public override void Up()
        {
            CreateIndex("Coins", new string[] { "SortOrderValue","Guid" },
                false, "IX_Coins_SortValue");
        }

        public override void Down()
        {
            DropIndex("Coins", "IX_Coins_SortValue");
        }

    }
}
