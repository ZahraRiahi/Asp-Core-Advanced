using Core.Domain.Product;
using Infrstructure.Data.Entities.Product;
using Core.Interface.Product;
namespace Infrstructure.Repository.Product;

public class Product : IProduct
{
    private readonly Context db;
    public Product(Context db)
    {
        this.db = db;

    }
    public void AddProduct(MProduct product)
    {
        var tblProduct = new Tbl_Product();
        tblProduct.ProductName = product.ProductName;
        tblProduct.Brand = product.Brand;
        tblProduct.Price = product.Price;
        tblProduct.Category = product.Category;
        tblProduct.ItemWeigth = product.ItemWeigth;
        tblProduct.Description = product.Description;
        db.Tbl_Products.Add(tblProduct);
        db.SaveChanges();
    }

    public void DeleteProduct(int id)
    {
       var product=db.Tbl_Products.Find(id);
       db.Tbl_Products.Remove(product);
       db.SaveChanges();

    }

    public List<MProduct> GetAllProduct()
    {
        var listProducts=db.Tbl_Products.ToList();
        List<MProduct> products=new List<MProduct>();
        foreach (var item in listProducts)
        {
            MProduct product=new MProduct();
            product.Id=item.Id;
            product.ProductName=item.ProductName;
            product.Brand=item.Brand;
            product.Price=item.Price;
            product.Category=item.Category;
            product.ItemWeigth=item.ItemWeigth;
            product.Description=item.Description;
            products.Add(product);
            
        }
        return products;
    }

    public void UpdateProduct(MProduct product)
    {
          var tbl_Product=db.Tbl_Products.Find(product.Id);
        tbl_Product.ProductName=product.ProductName;
        tbl_Product.Brand=product.Brand;
         tbl_Product.Price=product.Price;
         tbl_Product.Category=product.Category;
         tbl_Product.ItemWeigth=product.ItemWeigth;
         tbl_Product.Description=product.Description;
         db.SaveChanges();
    }



    public MProduct GetProductById(int id)
    {
         var product=db.Tbl_Products.Find(id);
         MProduct mProduct=new MProduct();
         mProduct.ProductName=product.ProductName;
         mProduct.Brand=product.Brand;
         mProduct.Price=product.Price;
         mProduct.Category=product.Category;
         mProduct.ItemWeigth=product.ItemWeigth;
         mProduct.Description=product.Description;
         mProduct.Id=product.Id;
         return mProduct;
    }

   
}