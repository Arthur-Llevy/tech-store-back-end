using api.entities;
using api.models;

namespace api.interfaces;

public interface IProductInterface
{
    ProductModel Create(ProductModel product);
    List<Product> GetAll();
    Product? GetById(int Id);
    void Update(int Id, ProductModel product);
    void Delete(int Id);
}