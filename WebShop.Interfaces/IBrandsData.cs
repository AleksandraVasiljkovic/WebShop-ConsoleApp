using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IBrandsData
    {
        List<BrandsModel> ReadBrands();

        void InsertBrand(BrandsModel brandsModel);
        void UpdateBrand(BrandsModel brandsModel);

        void DeleteBrand(int id);
        BrandsModel getBrandByName(string name);
    }
}
