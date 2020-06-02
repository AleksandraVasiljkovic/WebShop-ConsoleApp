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
    public class CategoriesDataXML : BaseData,ICategoriesData
    {
        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }
        

        public void InsertCategory(CategoriesModel categoriesModel)
        {
            string path = "C:\\temp\\Categories.XML";
            List<CategoriesModel> categoriesModels = new List<CategoriesModel>();
            if (File.Exists(path))
            {
                categoriesModels = ReadCategories();
            }
            categoriesModels.Add(categoriesModel);
            BaseData.InsertXML(categoriesModels,path);
        }

        public List<CategoriesModel> ReadCategories()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<CategoriesModel>));
            List<CategoriesModel> category;
            using (XmlReader reader = XmlReader.Create("C:\\temp\\Categories.XML"))
            {
                category = (List<CategoriesModel>)ser.Deserialize(reader);
            }
            return category;
        }

        public void UpdateCategory(int id, CategoriesModel categoriesModel)
        {
            throw new NotImplementedException();
        }
    }
}
