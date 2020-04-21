namespace SodaVendingService.Models
{
    public class Soda
    {
        public int SodaId { get; set; }

        public string SodaName { get; set; }

        public string SodaImageUrl { get; set; }

        public int SodaStock { get; set; }

        public int SodaPrice { get; set; }
    }
}