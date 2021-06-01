namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAllRowsFromCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("TRUNCATE TABLE Customers");
        }
        
        public override void Down()
        {
            
        }
    }
}
