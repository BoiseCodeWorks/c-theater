using theater.Interfaces;

namespace theater.Models
{
    public class Ticket : IPurchasable
    {
        public string Seat { get; set; }
        public bool Available { get; set; } = true;

        // Relationships
        public Movie Movie { get; set; }
        public Theater Theater { get; set; }
        public Cinema Cinema { get; set; }
        public Showtime Showtime { get; set; }
        public double Price { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public float Timestamp { get; set; }

        public double Purchase()
        {
            // throw new System.NotImplementedException();
            return 0.0;
        }
    }
}