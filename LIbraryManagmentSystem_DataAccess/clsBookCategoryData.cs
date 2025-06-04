using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsBookCategoryData
    {
        public static string GetCategoryName(int CategoryID)
        {
            string CategoryName = string.Empty;
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string query = "Select * FROM BookCategories WHERE CategoryID = @CategoryID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryID", CategoryID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                    CategoryName = (string)reader["CategoryName"];
                        
                    }
                return CategoryName;
                }
                catch
                (Exception ex)
                {
                return "";
                }
                finally
                {
                    connection.Close();
                }             
        }
        public static int GetCategoryID(string CategoryName)
        {
            int CategoryID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM BookCategories WHERE CategoryName = @CategoryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CategoryID = (int)reader["CategoryID"];

                }
                return CategoryID;
            }
            catch
            (Exception ex)
            {
                return CategoryID;
            }
            finally
            {
                connection.Close();
            }
        }
        public static int AddNewCategory(string  CategoryName)
        {
            int CategoryID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                            INSERT INTO [dbo].[BookCategories]
                            CategoryName
                            VALUE
                            @CategoryName;
                            SELECT SCOPE_IDENTITY();
                ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);
            
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewPersonID))
                {
                    CategoryID = CategoryID;
                }
            }
            catch
            (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return CategoryID;
        }
        public static bool UpdateCategory(int CategoryID, string CategoryName)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[BookCategories]
                               SET CategoryName = @CategoryName
                             WHERE CategoryID = @CategoryID;";
                        
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static bool DeletePerson(int CategoryID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM BookCategories
                             WHERE CategoryID = @CategoryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryID", CategoryID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }
        static public DataTable GetAllGategories()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select CategoryName from BookCategories";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
