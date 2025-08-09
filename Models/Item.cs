public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public decimal Price { get; set; }
    public string ShortDescription { get; set; }
    public string Brand { get; set; }
    public string ModelNumber { get; set; }
    public string Display { get; set; } = string.Empty;
    public string Processor { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string RearCamera { get; set; }
    public string FrontCamera { get; set; }
    public string Battery { get; set; }
    public string OperatingSystem { get; set; }
    public string Network { get; set; }
    public string SIM { get; set; }
    public string Color { get; set; }
    public string Weight { get; set; }
    public string Warranty { get; set; }
    public List<Review> Reviews { get; set; }
}

public class Review
{
    public string Author { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
}
