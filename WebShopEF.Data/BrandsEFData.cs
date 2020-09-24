using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class BrandsEFData : IBrandsData
    {
        public void DeleteBrand(int id)
        {
            using (var context = new WebShopContext())
            {
                context.Remove(context.BrandsModel.Select(p => p.BrandId == id));
                context.SaveChanges();
            }
        }

        public BrandsModel getBrandByName(string name)
        {
            using (var context = new WebShopContext())
            {
                BrandsModel brand = context.BrandsModel.Where(p => p.Name == name).SingleOrDefault();
                return brand;
            }
        }

        public void InsertBrand(BrandsModel brandsModel)
        {
            using (var context = new WebShopContext())
            {
                context.BrandsModel.Add(brandsModel);
                context.SaveChanges();
            }
        }

        public List<BrandsModel> ReadBrands()
        {
            using (var context = new WebShopContext())
            {
                List<BrandsModel> brands = context.BrandsModel.ToList();
                return brands;
            }
        }

        public void UpdateBrand(BrandsModel brandsModel)
        {
            using (var context = new WebShopContext())
            {
                var result = context.BrandsModel.SingleOrDefault(b => b.BrandId == brandsModel.BrandId);
                if (result != null)
                {
                    try
                    {
                        context.BrandsModel.Attach(brandsModel);
                        context.Entry(brandsModel).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
