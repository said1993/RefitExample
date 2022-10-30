namespace RefitExampleAPI.Repositories;

public class ProductsRepository
{
    private IList<Product> products;

    public ProductsRepository()
    {
        products = new List<Product>
        {
            new Product(1, "Tel Samsung Galaxy S22", "Tel Samsung Galaxy S22", 1300),
            new Product(2, "Tel Samsung Galaxy S22", "Tel Samsung Galaxy S22", 1300),
            new Product(3, "Tel Samsung Galaxy S22", "Tel Samsung Galaxy S22", 1300),
            new Product(4, "Tel Samsung Galaxy S22", "Tel Samsung Galaxy S22", 1300),
        };
    }

    public IList<Product> GetAll()
    {
        return products;
    }

    public Product? GetById(int id)
    {
        return products.FirstOrDefault(_=>_.Id == id);
    }

    public void Add(Product product)
    {
        products.Add(product);
    }

    public void Delete(Product product)
    {
        products.Remove(product);
    }
}
