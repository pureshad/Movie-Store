namespace Vidly001.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddNewColumn_Movie_NumberAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));

            Sql("UPDATE Movies SET NumberAvailable = Count");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
