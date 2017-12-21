using theater.Interfaces;

namespace theater.Models
{
    public class Concession : IPurchasable
    {
        public string SKU { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Timestamp { get; set; }

        public double Purchase()
        {
            var total = 0;
            return total;
        }
    }
}