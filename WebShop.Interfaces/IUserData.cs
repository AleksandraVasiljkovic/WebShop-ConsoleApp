using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IUserData
    {
        List<UserModel> ReadUsers();

        void InsertUser(UserModel userModel);

        void UpdateUser(UserModel userModel);

        void DeleteUser(int id);

        UserModel GetUserByName(string name);

        UserModel DeleteMaxId(List<UserModel> user);
        UserModel True(LoginModel loginModel);
    }
}
