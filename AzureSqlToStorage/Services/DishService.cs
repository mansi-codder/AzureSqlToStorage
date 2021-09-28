using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AzureSqlToStorage.Models;
namespace AzureSqlToStorage.Services
{
    public class DishService
    {
        // Ensure to change the below variables to reflect the connection details for your database
        private static string db_source = "deemoserver.database.windows.net";
        private static string db_user = "mansi";
        private static string db_password = "Sahil@14";
        private static string db_database = "demodb ";

        private SqlConnection GetConnection()
        {
            // Here we are creating the SQL connection
            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return new SqlConnection(_builder.ConnectionString);
        }

        public IEnumerable<Dish> GetDishes()
        {
            List<Dish> _lst = new List<Dish>();
            string _statement = "SELECT DishID ,DishImage ,DishName ,Rating from Dishes";
            SqlConnection _connection = GetConnection();
            // Let's open the connection
            _connection.Open();
            // We then construct the statement of getting the data from the dish table
            SqlCommand _sqlcommand = new SqlCommand(_statement, _connection);
            // Using the SqlDataReader class , we will read all the data from the dish table
            using (SqlDataReader _reader = _sqlcommand.ExecuteReader())
            {
                while (_reader.Read())
                {
                    Dish _course = new Dish()
                    {
                        DishID = _reader.GetInt32(0),
                        DishImage=_reader.GetString(1),
                        DishName = _reader.GetString(2),
                        Rating = _reader.GetDecimal(3)
                    };

                    _lst.Add(_course);
                }
            }
            _connection.Close();
            return _lst;
        }

    }
    }

    

