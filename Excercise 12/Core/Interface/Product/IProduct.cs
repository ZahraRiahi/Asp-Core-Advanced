using Core.Domain.Product;
namespace Core.Interface.Product;

public interface IProduct{
    //Create Product
    void AddProduct(MProduct product);

    //Read Product
    List<MProduct> GetAllProduct();

    //Update Product
    void UpdateProduct(MProduct product);

    //Delete Product
    void DeleteProduct(int id);

       //GetById Product
    MProduct GetProductById(int id);
}