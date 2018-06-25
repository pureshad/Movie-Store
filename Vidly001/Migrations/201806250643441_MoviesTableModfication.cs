namespace Vidly001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesTableModfication : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "Uploaded");
            DropColumn("dbo.Movies", "Count");
            DropColumn("dbo.Movies", "Genre_Id");
            DropTable("dbo.Genres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Genre_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Count", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Uploaded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
