namespace api.models;

public class ProductModel 
{
    public ProductModel(string Name)
    {
        this.Name = Name;
    }
    public string Name { get; set; } = default!;
}