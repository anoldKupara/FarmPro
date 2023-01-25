namespace FarmPro.Entities
{
    public class Feed
    {
        public int FeedID { get; set; }
        public string FeedType { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Quantity { get; set; }
        public string Comments { get; set; }
        public virtual ICollection<FeedConsumption> FeedConsumptions { get; set; }
    }
}
