namespace Car.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty; 
        public string ProductionYear { get;set; } 
        public decimal Price { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
    }
}
