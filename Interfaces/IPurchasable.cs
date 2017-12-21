namespace theater.Interfaces
{
    public interface IPurchasable
    {
        string SKU { get; set; }
        double Price { get; set; }
        string Name { get; set; }
        float Timestamp { get; set; }
        double Purchase();
    }
}