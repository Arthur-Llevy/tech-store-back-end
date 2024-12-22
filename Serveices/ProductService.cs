using api.entities;
using api.interfaces;
using api.models;
using Api.Context;

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

    public void Delete(int Id)
    {
        var productToDelete = _context.Product.Where(x => x.Id == Id).FirstOrDefault();

        if (productToDelete != null)
        {
            _context.Product.Remove(productToDelete);
            _context.SaveChanges();
        }
    }

    public List<Product> GetAll()
    {
        return _context.Product.ToList();
    }

    public Product? GetById(int Id)
    {
        var product = _context.Product.Where(x => x.Id == Id).FirstOrDefault();

        return product;
    }

    public void Update(int Id, ProductModel product)
    {
        var productToEdit = _context.Product.Where(x => x.Id == Id).FirstOrDefault();

        if (productToEdit != null)
        {
            productToEdit.Name = product.Name;
            _context.Product.Update(productToEdit);
            _context.SaveChanges();
        }
    }
}