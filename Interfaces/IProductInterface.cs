using api.entities;
using api.models;

namespace api.interfaces;

public interface IProductInterface
{
    ProductModel Create(ProductModel product);
    List<Product> GetAll();
    Product GetById(int id);
    void Update(Product product);
    void Delete(Product product);
}