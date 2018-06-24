namespace Vidly001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MovieTypes_Id", "dbo.MovieTypes");
            DropIndex("dbo.Movies", new[] { "MovieTypes_Id" });
            DropColumn("dbo.Movies", "MovieTypesId");
            DropColumn("dbo.Movies", "MovieTypes_Id");
            DropTable("dbo.MovieTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Genre = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Uploaded = c.DateTime(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movie", "MovieTypes_Id", c => c.Byte());
            AddColumn("dbo.Movie", "MovieTypesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movie", "MovieTypes_Id");
            AddForeignKey("dbo.Movie", "MovieTypes_Id", "dbo.MovieTypes", "Id");
        }
    }
}
