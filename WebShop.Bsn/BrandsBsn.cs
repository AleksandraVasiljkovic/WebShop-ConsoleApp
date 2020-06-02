using System;
using System.Collections.Generic;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Bsn
{
    public class BrandsBsn
    {
        public IBrandsData brandsData;
        public BrandsBsn()
        {
            brandsData = new BrandsData();
            if (Source.DataStorage==1)
            {
                brandsData = new BrandsDataXML();
            }
        }
        public List<BrandsModel> Read()
        {
            List<BrandsModel> brandsList = new List<BrandsModel>();
            return brandsData.ReadBrands();

        }
        public void Insert(BrandsModel brandsModel)
        {
            brandsData.InsertBrand(brandsModel);
        }
        public void Update(int id, BrandsModel brandsModel)
        {
            brandsData.UpdateBrand(id, brandsModel);
        }

        public void Delete(int id)
        {
            brandsData.DeleteBrand(id);
        }
    }
}
