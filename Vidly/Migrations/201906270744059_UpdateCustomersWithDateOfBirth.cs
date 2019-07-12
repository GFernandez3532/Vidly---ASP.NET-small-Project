namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomersWithDateOfBirth : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers SET DateOfBirth='01/02/1985' WHERE id=1");
            Sql("Update Customers SET DateOfBirth='04/07/1993' WHERE id=2");
        }
        
        public override void Down()
        {
        }
    }
}
