namespace Vidly001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesTableModfication_2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Uploaded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Count", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Movies", "Name", c => c.String(maxLength: 255));
            AddPrimaryKey("dbo.Movies", "Id");
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Name", c => c.String());
            AlterColumn("dbo.Movies", "Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "Count");
            DropColumn("dbo.Movies", "Uploaded");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "GenreId");
            DropTable("dbo.Genres");
            AddPrimaryKey("dbo.Movies", "Id");
        }
    }
}
