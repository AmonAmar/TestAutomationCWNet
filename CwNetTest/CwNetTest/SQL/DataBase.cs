using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using CwNetTest.Core;
using System.Data;
using System.Configuration;

namespace CwNetTest.SQL
    {
    public class DataBase : Settings
        {
        public static SqlConnection connectionCWN()
            {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[CommonMethods.CW_NET_DATA_BASE].ConnectionString);
                //string.Concat("Server=", "dev3-kiev", ";Database=", "UKR_CWN_26092017_150927", ";Integrated Security=True;"));
            connection.Open();
            return connection;
            }

        public static List<Dictionary<string, string>> execute(string nameOfSQLFile, string parameter = "")
            {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            SqlCommand command = new SqlCommand();
            command.Connection = connectionCWN();
            command.CommandType = CommandType.Text;
            command.CommandText = new FileInfo(CommonMethods.PATH_OF_SQL_FILE + nameOfSQLFile).OpenText().ReadToEnd().Replace("@parameter", "'"+parameter+"'");
            SqlDataReader reader = command.ExecuteReader();
            do
                {
                    int count = reader.FieldCount;
                    while (reader.Read())
                        {
                        Dictionary<string, string> rowOfResult = new Dictionary<string, string>();
                        for (int firstRow = 0; firstRow < count; firstRow++)
                            {
                            string nameOfColumn = reader.GetName(firstRow);
                            string valueOfColumn = reader.GetValue(firstRow).ToString();
                            rowOfResult.Add(nameOfColumn, valueOfColumn);
                            }
                        result.Add(rowOfResult);
                        }
                    }
                while (reader.NextResult());
                
            return result;
            }
        }
    }
