using ADONet_Start.Models;
using ADONet_Start.Services;
/*
using (SqlConnection connect=new SqlConnection())
{
    connect.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Testdb;Trusted_Connection=True;"; 
    connect.Open();

    string query = "Select * from Customers";
    SqlCommand sqlCommand=new SqlCommand(query,connect);

    using(SqlDataReader reader=sqlCommand.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader[0]} ");
            Console.WriteLine($"Name {reader["name"]}");
        }
    }
}
*/

/*
string tableName = "Customers";
string databaseName = "Testdb";
// Database.CreatTable(tableName,databaseName);
var columns = new List<ColumnModel>()
{
    new ColumnModel(){ Name="Id",Typelari="int not null identity(1,1)"},
    new ColumnModel(){ Name="Name",Typelari="varchar(30)"},
    new ColumnModel(){ Name="Age",Typelari="int"},

};

Database.GetAll(tableName, databaseName);

*/

string tableName = "Customers";
string databaseName = "Testdb";
string value = "('Ali',17),('Vali',17);";

List<ColumnModel> columns = new List<ColumnModel>()
{
    new ColumnModel(){Name="Id",Typelari="int not null identity(1,1)"},
    new ColumnModel(){Name="Name",Typelari="varchar(40)"},
    new ColumnModel(){Name="Age",Typelari="int" }
};

//Database.CreateTable(tableName, databaseName,columns);


//Database.GetAll(tableName,databaseName);
//Database.Insert(databaseName, tableName, value);
Database.Delete(databaseName, tableName);