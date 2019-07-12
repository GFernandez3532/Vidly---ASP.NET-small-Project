namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataInMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock) VALUES ('Hangover',05/03/2008,06/27/2019,5)");
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock) VALUES ('Die Hard',13/01/2008,06/27/2019,13)");
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock) VALUES ('The Terminator',15/08/2009,06/27/2019,23)");
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock) VALUES ('Toy Story',05/12/2003,06/27/2019,7)");
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock) VALUES ('Titanic',05/03/2008,06/27/2019,11)");
        }
        
        public override void Down()
        {
        }
    }
}
