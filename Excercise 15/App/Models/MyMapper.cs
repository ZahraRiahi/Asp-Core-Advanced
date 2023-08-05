namespace App.Models;
using AutoMapper;
public class MyMapper:Prodile{
    public MyMapper()
    {
        //map MProduct to Tbl_Product 
        CreateMap<MProduct,Tbl_Product>().ReverseMap();
        CreateMap<Tbl_Product,MProduct>().ReverseMap();

    }
}