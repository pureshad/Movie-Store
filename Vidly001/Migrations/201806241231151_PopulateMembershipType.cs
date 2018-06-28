namespace Vidly001.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SubscriptionTypeName, SignUpFee, DurationInMonth, DiscountRate) VALUES (1, 'Trial', 0, 1, 0)");
            Sql("INSERT INTO MembershipTypes(Id, SubscriptionTypeName, SignUpFee, DurationInMonth, DiscountRate) VALUES (2, 'Monthly', 30, 3, 15)");
            Sql("INSERT INTO MembershipTypes(Id, SubscriptionTypeName, SignUpFee, DurationInMonth, DiscountRate) VALUES (3, 'Life Time', 300, 12, 30)");
            Sql("INSERT INTO MembershipTypes(Id, SubscriptionTypeName, SignUpFee, DurationInMonth, DiscountRate) VALUES (4, 'Pay as you go', 90, 6, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
