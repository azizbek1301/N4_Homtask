using ADONet_Start.Models;
using System.Data.SqlClient;

namespace ADONet_Start.Services;

public class Database
{
    public static void CreateTable(string TableName, string DatabaseName, List<ColumnModel> columns)
    {
        using (SqlConnection connect = new SqlConnection())
        {

            string connectionString = $"Server = (localdb)\\MSSQLLocalDB; Database ={DatabaseName}; Trusted_Connection = True;";
            connect.ConnectionString = connectionString;
            connect.Open();

            string nimadur = $"Create table {TableName}(";
            var query = columns.Aggregate(nimadur, (x1, x2) => x1 += x2.Name + " " + x2.Typelari + ","
                                                    , (x) => x.Substring(0, x.Length - 1) + ");");


            //string query = $"create table {TableName}(Id int not null," +
            //                                        $"Name varchar(30)," +
            //                                        $"Age int not null)";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Succesfully table created");




        }
    }

    public static void GetAll(string TableName, string DatabaseName)
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = $"Server = (localdb)\\MSSQLLocalDB; Database ={DatabaseName}; Trusted_Connection = True;";
            connect.Open();
            string query = $"select * from {TableName}";
            SqlCommand sqlCommand = new SqlCommand(query, connect);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                int count = reader.FieldCount;
                //int i = 0;
                while (reader.Read())
                {
                    for (int j = 0; j < count; j++)
                    {
                        Console.Write($"col{j} {reader[j]}");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
    public static void Insert(string DatabaseName, string TableName, string values)
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = $"Server = (localdb)\\MSSQLLocalDB; Database ={DatabaseName}; Trusted_Connection = True;";
            connect.Open();
            string query = $"select * from {TableName}";
            SqlCommand sqlCommand = new SqlCommand(query, connect);
            dynamic res;
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                res = reader.GetColumnSchema();

            }
            string result = String.Empty;
            foreach (var item in res)
            {
                if (item.ColumnName.ToUpper() != "id".ToUpper())
                {
                    result += item.ColumnName + ",";
                }
            }
            result = result.Substring(0, result.Length - 1);
            string query2 = $"Insert Into {TableName} values {values}";
            SqlCommand sqlCommand2 = new SqlCommand(query2, connect);
            using (SqlDataReader reader2 = sqlCommand2.ExecuteReader())
            {

            }
        }

    }
    public static void Delete(string DatabaseName, string TableName)
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = $"Server = (localdb)\\MSSQLLocalDB; Database ={DatabaseName}; Trusted_Connection = True;";
            connect.Open();
            string query = $"Drop table {TableName}";
            SqlCommand sqlCommand = new SqlCommand(query, connect);

        }
    }
}

