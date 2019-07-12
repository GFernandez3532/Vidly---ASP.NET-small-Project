namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Hangover',05/03/2008,06/27/2019,5,5)");
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Die Hard',13/01/2008,06/27/2019,13,1)");
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('The Terminator',15/08/2009,06/27/2019,23,1)");
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Toy Story',05/12/2003,06/27/2019,7,3)");
            Sql("Insert INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Titanic',05/03/2008,06/27/2019,11,4)");
        }
        
        public override void Down()
        {
        }
    }
}
