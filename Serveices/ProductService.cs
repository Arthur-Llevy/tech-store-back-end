using api.entities;
using api.interfaces;
using api.models;
using Api.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace api.services;

public class ProductService : IProductInterface
{

    private Context _context;

    public ProductService(Context context)
    {
        _context = context;
    }
    public ProductModel Create(ProductModel product)
    {
        Product newProduct = new Product();
        newProduct.Name = product.Name;
        _context.Product.Add(newProduct);

        _context.SaveChanges();
        return product;
    }

    public void Delete(Product product)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return _context.Product.ToList();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Product product)
    {
        throw new NotImplementedException();
    }
}