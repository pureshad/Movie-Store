namespace Vidly001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumn_SubscriptionTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SubscriptionTypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "SubscriptionTypeName");
        }
    }
}
