namespace Cool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes(Id , Name) VALUES (1 , 'Action')");
            Sql("INSERT INTO GenreTypes(Id , Name) VALUES (2 , 'Comedy')");
            Sql("INSERT INTO GenreTypes(Id , Name) VALUES (3 , 'Romance')");
            Sql("INSERT INTO GenreTypes(Id , Name) VALUES (4 , 'Sci-Fi')");
            Sql("INSERT INTO GenreTypes(Id , Name) VALUES (5 , 'Adventure')");
        }
        
        public override void Down()
        {
        }
    }
}
