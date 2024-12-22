using api.entities;
using api.interfaces;
using api.models;
using api.services;
using Microsoft.AspNetCore.Mvc;

namespace tech_store.Controllers;

[ApiController]
[Route("/product")]    
public class ProductController : ControllerBase
{
    private readonly IProductInterface _productService; 
    public ProductController(IProductInterface productService) 
    {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult<List<Product>> GetAllProducts()
    {
        List<Product> products = _productService.GetAll();
        return Ok(products);
    }

    [HttpPost]
    public ActionResult<ProductModel> Create(ProductModel product)
    {
        var newProduct = _productService.Create(product);
        return Ok(newProduct);
    }
}
