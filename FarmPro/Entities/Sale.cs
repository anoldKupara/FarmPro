namespace FarmPro.Entities
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int AnimalID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SalePrice { get; set; }
        public string Comments { get; set; }
        public virtual Animal Animal { get; set; }
    }
}
