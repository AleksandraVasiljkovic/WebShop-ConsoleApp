﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Data
{
    public class BrandsData:BaseData, IBrandsData
    {
        public List<BrandsModel> ReadBrands()
        {
            try
            {
                OpenSqlConnection();
                CreateCommandSc("SelectAllBrands");
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<BrandsModel> brandsList = new List<BrandsModel>();

                while (sqlDataReader.Read())
                {
                    BrandsModel brandsModel = new BrandsModel();
                    brandsModel.BrandId = Convert.ToInt32(sqlDataReader["BrandId"]);
                    brandsModel.Name = sqlDataReader["Name"].ToString();
                    brandsModel.Country = sqlDataReader["Country"].ToString();

                    brandsList.Add(brandsModel);
                }
                return brandsList;
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


        public void InsertBrand(BrandsModel brandsModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertBrand");
                sqlCommand.Parameters.Add(new SqlParameter("@Name", brandsModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Country", brandsModel.Country));
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
        public void UpdateBrand(BrandsModel brandsModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("UpdateBrand");
                sqlCommand.Parameters.Add(new SqlParameter("@BrandId", brandsModel.BrandId));
                sqlCommand.Parameters.Add(new SqlParameter("@Name", brandsModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Country", brandsModel.Country));
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

        public void DeleteBrand(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("DeleteBrand");
                sqlCommand.Parameters.Add(new SqlParameter("@BrandId", id));
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
        public BrandsModel getBrandByName(string name)
        {
            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("GetBrandByName");
                sqlCommand.Parameters.Add(new SqlParameter("@Name", name));
                SqlDataReader sqlDataReader = GetExecuteReader();
                BrandsModel brandsModel = new BrandsModel();
                while (sqlDataReader.Read())
                { 
                brandsModel.BrandId = Convert.ToInt32(sqlDataReader["BrandId"]);
                brandsModel.Name = sqlDataReader["Name"].ToString();
                brandsModel.Country = sqlDataReader["Country"].ToString();
                }
                return brandsModel;
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
