using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber5
{
    internal class DataAccess
    {
        private const string connectionString = "Data Source=DESKTOP-TDIEBBV\\SQLEXPRESS01;Initial Catalog=OnlineStoreDb;Integrated Security=True;Trust Server Certificate=True";
        
        public void ReadDataUsingDataReader()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select product_id as id,product_name,model_year from production.products;";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["id"]}  {reader["Product_name"]} {reader[2]}");
                    }
                }

            }

        }

        public void ReadDataUsingDataAdapter()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from production.brands;";

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    DataTable table = dataSet.Tables[0];

                    table.Rows.Add([20, "sdfsdf"]);
                    DataRow dataRow = table.Rows[0];
                    dataRow["brand_name"] = "Test test";
                    adapter.Update(dataSet);
                    //foreach(DataColumn dataColumn in table.Columns) {
                    //    Console.Write(dataColumn.ColumnName + "      ");
                    //}
                    //Console.WriteLine();
                    //foreach (DataRow row in table.Rows)
                    //{
                    //    //Console.WriteLine(row["Id"] + "      " + row["name"]);
                        
                    //}
                }
            }
        }

        public void ReadDataUsingStoredProcedure()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "GetAllProducts";
                command.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@category_id",
                    Value = 5
                });

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["product_id"]}  {reader["Product_name"]}");
                    }
                }

            }

        }

        public void UpdateData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "update production.brands set brand_name = 'foo' where brand_id = 1; ";

                int numOfRows = command.ExecuteNonQuery();
                if (numOfRows > 0)
                {
                    Console.WriteLine($"You updated {numOfRows} row");
                }
            }
        }
    }
}
