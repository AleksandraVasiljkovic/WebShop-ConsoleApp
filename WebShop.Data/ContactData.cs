using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebShop.Model;
using WebShop.Interfaces;

namespace WebShop.Data
{
    public class ContactData : BaseData, IContactData
    {
        public void InsertContact(ContactModel contactModel)
        {
            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertContact");
                sqlCommand.Parameters.Add(new SqlParameter("@Name", contactModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Email", contactModel.Email));
                sqlCommand.Parameters.Add(new SqlParameter("@Message", contactModel.Message));
                ExecutedNonQuery();
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
            finally
            {
                CloseSqlConnection();
            }
        }

    }
}
