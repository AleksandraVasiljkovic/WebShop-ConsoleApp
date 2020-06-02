using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Data
{
    public class BrandsDataXML : BaseData,IBrandsData
    {
        public void DeleteBrand(int id)
        {
            throw new NotImplementedException();
        }
        
        public void InsertBrand(BrandsModel brandsModel)
        {
            string path = "C:\\temp\\Brands.XML";
            List<BrandsModel> brandsModels=new List<BrandsModel>();
            if (File.Exists(path))
            {
                brandsModels = ReadBrands();
            }
            brandsModels.Add(brandsModel);
            BaseData.InsertXML(brandsModels, path);
        }

        public List<BrandsModel> ReadBrands()
        {

            XmlSerializer ser = new XmlSerializer(typeof(List<BrandsModel>));
            List<BrandsModel> brand;
            using (XmlReader reader = XmlReader.Create("C:\\temp\\Brands.XML"))
            {
                brand = (List<BrandsModel>)ser.Deserialize(reader);
            }
            return brand;
        }

        public void UpdateBrand(int id, BrandsModel brandsModel)
        {
            throw new NotImplementedException();
        }
    }
}
