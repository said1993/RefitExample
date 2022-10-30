namespace RefitExampleAPI;

public class Product
{
    public Product(int id, string name, string description, decimal price)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Decimal Price { get; set; }
}
