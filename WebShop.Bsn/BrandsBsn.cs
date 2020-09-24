using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class BrandsBsn
    {
        public IBrandsData brandsData;
        public BrandsBsn()
        {
            brandsData = new BrandsEFData();
            if (Source.DataStorage==1)
            {
                brandsData = new BrandsDataXML();
            }
        }
        public List<BrandsModel> Read()
        {
            return brandsData.ReadBrands();
        }
        public void Insert(BrandsModel brandsModel)
        {
            brandsData.InsertBrand(brandsModel);
        }
        public void Update(BrandsModel brandsModel)
        {
            brandsData.UpdateBrand(brandsModel);
        }

        public void Delete(int id)
        {
            brandsData.DeleteBrand(id);
        }
        public BrandsModel getBrandByNameBsn(string name)
        {
            BrandsModel brandsModel = brandsData.getBrandByName(name);
            return brandsModel;
        }
    }
}
