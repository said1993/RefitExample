using Microsoft.AspNetCore.Mvc;
using RefitExampleAPI.Repositories;

namespace RefitExampleAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;
    private readonly ProductsRepository _productsRepository;

    public ProductsController(ILogger<ProductsController> logger, ProductsRepository productsRepository)
    {
        _logger = logger;
        _productsRepository = productsRepository;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return _productsRepository.GetAll();
    }

    [HttpGet("{id}")]
    public Product? Get(int id)
    {
        return _productsRepository.GetById(id);
    }

    [HttpPost]
    public IActionResult Add(Product product)
    {
        _productsRepository.Add(product);
        return Ok();

    }

    [HttpDelete]
    public IActionResult Delete(Product product)
    {
        _productsRepository.Add(product);
        return Ok();
    }
}
