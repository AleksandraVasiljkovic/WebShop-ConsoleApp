using System;
using System.Collections.Generic;
using WebShop.Data;

using WebShop.Interfaces;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class UserBsn
    {
        public IUserData userData;
        public UserBsn()
        {
            userData = new UserEFData();
        }
        public List<UserModel> Read()
        {
            return userData.ReadUsers();
        }
        public bool Insert(UserModel userModel)
        {
            try
            {
                userData.InsertUser(userModel);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Update(UserModel userModel)
        {
            userData.UpdateUser(userModel);
        }

        public void Delete(int id)
        {
            userData.DeleteUser(id);
        }
        public UserModel GetUserByNameBsn(string name)
        {
            return userData.GetUserByName(name);
        }
        public UserModel DeleteMaxIdBSN()
        {
            List<UserModel> list = Read();
            UserModel deletedUser = userData.DeleteMaxId(list);
            return deletedUser;
        }
        public UserModel True(LoginModel loginModel)
        {
            try
            {
                UserModel userModel = userData.True(loginModel);
                return userModel;
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
