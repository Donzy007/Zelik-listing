namespace Zelik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES(1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(3, 'Drame')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(4, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(5, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(6, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
