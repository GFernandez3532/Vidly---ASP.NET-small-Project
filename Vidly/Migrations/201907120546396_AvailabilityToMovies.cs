namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AvailabilityToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies SET numberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
