using Core.Domain.Product;
using Infrstructure.Data.Entities.Product;
using Core.Interface.Product;
using System.Linq;
using AutoMapper;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
namespace Infrstructure.Repository.Product;

public class Product : IProduct
{
    private readonly Context _db;
        private readonly IMapper _mapper;


    public Product(Context db,IMapper mapper)
    {
        _db = db;
        _mapper=mapper;

    }
    public void AddProduct(MProduct product)
    {
        Tbl_Product tbl_Product=_mapper.Map<Tbl_Product>(product);
     
    }

    public List<MProduct> GetAllProduct()
    {
        var listProducts=_db.Tbl_Products.ToList();
        List<MProduct> products=_mapper.Map<List<MProduct>>(listProducts);
        return products;
    }
   
}