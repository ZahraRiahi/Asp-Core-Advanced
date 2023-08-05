using Core.Domain.Product;
namespace Core.Interface.Product;

public interface IProduct{
    //Create Product
    void AddProduct(MProduct product);

    // get list of Product
    List<MProduct> GetAllProduct();


}