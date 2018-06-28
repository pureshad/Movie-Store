namespace Vidly001.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class NewValidationMovieNameRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(maxLength: 255));
        }
    }
}