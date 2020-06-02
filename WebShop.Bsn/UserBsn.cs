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
            List<UserModel> userList = new List<UserModel>();
            return userData.ReadUsers();
        }
        public void Insert(UserModel userModel)
        {
            userData.InsertUser(userModel);
        }
        public void Update(int id, UserModel userModel)
        {
            userData.UpdateUser(id, userModel);
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



    }
}
