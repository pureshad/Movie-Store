namespace Vidly001.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies_2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, Uploaded, Count) VALUES (3, 'Triple X', 1, '9 August 2002', '24 December 2002', 240)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, Uploaded, Count) VALUES (4, 'Mission: Impossible', 2, '16 May 1996', '16 Jun 1996', 50)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, Uploaded, Count) VALUES (5, 'Titanic', 4, '19 December 1997', '28 December 1997', 130)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, Uploaded, Count) VALUES (6, 'Pixels', 5, ' 24 July 2015', ' 30 July 2015', 200)");
        }

        public override void Down()
        {
        }
    }
}
