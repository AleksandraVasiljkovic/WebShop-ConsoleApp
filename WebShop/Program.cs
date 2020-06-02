using System;
using WebShop.Model;
using WebShop.Bsn;
using System.Collections.Generic;

namespace WebShop
{
    class Program
    {
        static void Main(string[] args)
        {

            BrandsBsn brandsBsn = new BrandsBsn();
            BrandsModel brandsModel = new BrandsModel("Shar", "Nemacka");
            brandsBsn.Insert(brandsModel);

            List<BrandsModel> list = brandsBsn.Read();
            foreach (var x in list)
            {
                Console.WriteLine(x.Name + ' ' + x.Country);
            }

            CategoriesBsn categoriesBsn = new CategoriesBsn();
            CategoriesModel categoriesModel = new CategoriesModel("Brasno", "Proso i Heljda");
            categoriesBsn.Insert(categoriesModel);

            List<CategoriesModel> list1 = categoriesBsn.Read();
            foreach (var x in list1)
            {
                Console.WriteLine(x.Name + ' ' + x.Description);
            }



            List<ProductModel> productModels = new List<ProductModel>();
            ProductBsn productBsn = new ProductBsn();
            productModels = productBsn.Read();
            foreach (var l in productModels)
            {
                Console.WriteLine(l.ToString());
            }

            ProductModel productModel = new ProductModel("papaja", 2, 3, 400, 400);
            productBsn.Insert(productModel);
            ProductBsn productBsn = new ProductBsn();
            List<ProductModel> productModels = productBsn.Read();

            ProductModel productModelU = new ProductModel("smoki", 2, 3, 400, 300);
            int idU = 6;
            productBsn.Update(idU, productModelU);

            int idD = 7;
            productBsn.Delete(idD);

            RestaurantsBsn restaurantsBsn = new RestaurantsBsn();
            RestaurantsModel restaurantsModel = new RestaurantsModel("Aleksandar", "Vidikovac", "www.aleksandar.com", "Restoran sa pogledom");
            restaurantsBsn.Insert(restaurantsModel);

            List<RestaurantsModel> restaurantsModels = restaurantsBsn.Read();
            foreach (var l in restaurantsModels)
            {
                Console.WriteLine(l.ToString());
            }



            RecipesBsn recipesBsn = new RecipesBsn();
            RecipesModel recipesModel = new RecipesModel("Kolac sa bananama", "solja brasna ,solja pavlake");
            recipesBsn.Insert(recipesModel);

            List<RecipesModel> recipesModels = recipesBsn.Read();
            foreach (var x in recipesModels)
            {
                Console.WriteLine(x.Name + ' ' + x.Description);
            }


            UserBsn userBsn = new UserBsn();
            List<UserModel> listUsers = userBsn.Read();
            foreach (var l in listUsers)
            {
                Console.WriteLine(l.ToString());
            }

            UserModel userModel = new UserModel("Radovan", "Jovanovic", "Vidikovac", "0637467904", "radovanjovanovic@gmail.com");
            userBsn.Insert(userModel);
            userBsn.Read();


            OrdersBsn ordersBsn = new OrdersBsn();
            OrdersModel ordersModel = new OrdersModel(1, DateTime.Now, 50.3);
            ordersBsn.Insert(ordersModel);

            UserBsn userBsn = new UserBsn();
            string name = "Radovan";
            UserModel userModel = userBsn.GetUserByNameBsn(name);
            Console.WriteLine(userModel.ToString());

            UserBsn userBsn = new UserBsn();
            List<UserModel> list = userBsn.Read();
            UserModel deletedUser = userBsn.DeleteMaxIdBSN();
            Console.WriteLine("User" + ' ' + deletedUser.ToString() + ' ' + "is deleted");


            Console.ReadLine();
        }
    }
}
