namespace Vidly001.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, Uploaded, Count) VALUES (2, 'Harry Potter', 3, '16 November 2001', '16 December 2001', 30)");
        }

        public override void Down()
        {
        }
    }
}
