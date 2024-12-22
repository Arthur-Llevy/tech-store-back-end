using System.Runtime.CompilerServices;
using api.entities;
using api.interfaces;
using api.models;
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

    [HttpGet("{Id}")]
    public ActionResult<Product>? GetById(int Id)
    {
        return _productService.GetById(Id);
    }

    [HttpPost]
    public ActionResult<ProductModel> Create(ProductModel product)
    {
        var newProduct = _productService.Create(product);
        return Ok(newProduct);
    }

    [HttpDelete("{Id}")]
    public ActionResult Delete(int Id)
    {
        _productService.Delete(Id);
        return Ok();
    }

    [HttpPatch("{Id}")]
    public ActionResult Update(int Id, ProductModel product)
    {
        _productService.Update(Id, product);
        return Ok();
    }
}
