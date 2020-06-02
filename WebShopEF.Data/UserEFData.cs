using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class UserEFData : IUserData
    {
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

       
        public void InsertUser(UserModel userModel)
        {
            using (var context = new WebShopContext())
            {
                context.UserModel.Add(userModel);
                context.SaveChanges();
            }
        }

        public List<UserModel> ReadUsers()
        {
            using (var context = new WebShopContext())
            {
                List<UserModel> users = context.UserModel.ToList();
                return users;
            }

        }

        

        public void UpdateUser(int id, UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserByName(string name)
        {
            using (var context = new WebShopContext())
            {
                UserModel user = context.UserModel.Where(u=>u.Name==name).FirstOrDefault();
                return user;
            }
        }
        public UserModel DeleteMaxId(List<UserModel> list)
        {
            using (var context = new WebShopContext())
            {
                
                var id=list.Max(u => u.UserId);
                UserModel deleteUser = context.UserModel.Where(u => u.UserId == id).FirstOrDefault();
                context.UserModel.Remove(deleteUser);
                context.SaveChanges();
                return deleteUser;
                
            }
        }

    }
}
