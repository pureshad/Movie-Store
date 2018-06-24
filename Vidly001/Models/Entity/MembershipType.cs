namespace Vidly001.Models.Entity
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string SubscriptionTypeName { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}