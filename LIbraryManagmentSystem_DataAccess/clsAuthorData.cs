using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsAuthorData
    {
        static public bool GetAuthorInfoByID(int AuthorID, ref int PersonID, ref DateTime CreatedDate)
        {
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Authors Where AuthorID = @AuthorID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                }
                return true;
            }
            catch
            (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        static public int AddNewAuthor( int PersonID)
        {
            int AuthorID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string procedureName = @"sp_AddNewAuthor";
            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);
            SqlParameter returnedValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
            returnedValue.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(returnedValue);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                AuthorID = (int)returnedValue.Value;
            }
            catch
            (Exception ex)
            {
                return AuthorID;
            }
            finally
            {
                connection.Close();
            }
            return AuthorID;
        }
       
        static public bool DeleteAuthor(int AuthorID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from Authors where AuthorID = @AuthorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AuthorID", AuthorID);

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
        static public DataTable GetAllAuthors()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from Authors_View";
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
        static public string GetAuthorName(int AuhtorID)
        {
            string AuthorName = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select AuthorName from Authors_View where AuthorID = @AuhtorID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuhtorID", AuhtorID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null )
                {
                    AuthorName = result.ToString();
                }
                return AuthorName;
            }
            catch
            (Exception ex)
            {
                return AuthorName;
            }
            finally
            {
                connection.Close();
            }
        }
        static public int GetAuthorID(string AuthorName)
        {
            int AuthorID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select AuthorID from Authors_View where AuthorName = @AuthorName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorName", AuthorName);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int NewAuthorID))
                {
                    AuthorID = NewAuthorID;
                }
                return AuthorID;
            }
            catch
            (Exception ex)
            {
                return AuthorID;
            }
            finally
            {
                connection.Close();
            }
        }
        static public int GetTotalAuthors()
        {
            byte TotalAuthor = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalAuthors = Count(AuthorID) from Authors";

            SqlCommand command = new SqlCommand(query, connection);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
                {
                    TotalAuthor = ptCount;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return TotalAuthor;
        }
        static public DataTable GetAllBooks(string author)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from Book_View where author = @author";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@author", author);

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

