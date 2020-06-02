using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.IO;

namespace WebShop.Data
{
    public class BaseData
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;

        protected BaseData()
        {

            sqlConnection = new SqlConnection("Server=localhost\\sqlexpress;Database=WebShop;Trusted_Connection=true");
        }

        protected void OpenSqlConnection()
        {
        if (sqlConnection.State != ConnectionState.Open)
        {
            sqlConnection.Close();
            sqlConnection.Open();
        };
        
        }
        protected SqlCommand CreateCommandSc(string sc)
        {

            sqlCommand = new SqlCommand(sc, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return sqlCommand;
        }

        protected SqlDataReader GetExecuteReader()
        {
            return sqlCommand.ExecuteReader();
        }

        protected void ExecutedNonQuery()
        {
            sqlCommand.ExecuteNonQuery();
        }
        protected void CloseSqlConnection()
        {
            sqlConnection.Close();
            
        }
        public static void InsertXML<T>(List<T> typeModels, string path)
        {
            XmlSerializer x = new XmlSerializer(typeModels.GetType());
            TextWriter writer = new StreamWriter(path);
            x.Serialize(writer, typeModels);
            writer.Close();
        }
    }


}
