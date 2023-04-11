namespace FarmPro.Entities
{
    public class Vaccine
    {
        public int VaccineID { get; set; }
        public string VaccineType { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Comments { get; set; }
    }
}
