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
            using (var context = new WebShopContext())
            {
                context.Remove(context.UserModel.Select(p => p.UserId == id));
                context.SaveChanges();
            }
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

        public void UpdateUser(UserModel userModel)
        {
            using (var context = new WebShopContext())
            {
                var result = context.UserModel.SingleOrDefault(b => b.UserId == userModel.UserId);
                if (result != null)
                {
                    try
                    {
                        context.UserModel.Attach(userModel);
                        context.Entry(userModel).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
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
        public UserModel True(LoginModel loginModel)
        {
            using (var context = new WebShopContext())
            {
                UserModel user = context.UserModel.Where(u => u.Email == loginModel.Email && u.Password==loginModel.Password).FirstOrDefault();
                return user;
            }
        }
    }
}
