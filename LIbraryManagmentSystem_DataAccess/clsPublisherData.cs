using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsPublisherData
    {
        static public bool GetPublisherInfoByID(int PublisherID, ref int PersonID, ref DateTime CreatedDate)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Publishers Where PublisherID = @PublisherID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PublisherID", PublisherID);
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

        static public int AddNewPublisher(int PersonID)
        {
            int PublisherID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string procedureName = @"sp_AddNewPublisher";
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
                PublisherID = (int)returnedValue.Value;
            }
            catch
            (Exception ex)
            {
                return PublisherID;
            }
            finally
            {
                connection.Close();
            }
            return PublisherID;
        }
        //static public bool UpdatePublisher(int PublisherID, string Name, string Phone, string Email)
        //{
        //    int rowsAffected = 0;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string procedureName = @"sp_UpdatePublisher";
        //    SqlCommand command = new SqlCommand(procedureName, connection);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@Name", Name);
        //    command.Parameters.AddWithValue("@Phone", Phone);
        //    command.Parameters.AddWithValue("@Email", Email);
        //    command.Parameters.AddWithValue("@PublisherID", PublisherID);
        //    SqlParameter returnedValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
        //    returnedValue.Direction = ParameterDirection.ReturnValue;
        //    command.Parameters.Add(returnedValue);

        //    try
        //    {
        //        connection.Open();

        //        command.ExecuteNonQuery();
        //        rowsAffected = (int)returnedValue.Value;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return rowsAffected > 0;
        //}
        static public bool DeletePublisher(int PublisherID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from Publishers where PublisherID = @PublisherID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PublisherID", PublisherID);

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
        static public DataTable GetAllPublishers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from Publishers_View";
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
        static public string GetPublisherName(int PublisherID)
        {
            string PublisherName = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select PublisherName from Publishers_View where PublisherID = @PublisherID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PublisherID", PublisherID);
            try
            {
                connection.Open();
                PublisherName = command.ExecuteScalar().ToString();

                return PublisherName;
            }
            catch
            (Exception ex)
            {
                return PublisherName;
            }
            finally
            {
                connection.Close();
            }
        }
        static public int GetPublisherID(string PublisherName)
        {
            int PublisherID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select PublisherID from Publishers_View where PublisherName = @PublisherName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PublisherName", PublisherName);
            try
            {
                connection.Open();
                PublisherID = int.Parse(command.ExecuteScalar().ToString());

                return PublisherID;
            }
            catch
            (Exception ex)
            {
                return PublisherID;
            }
            finally
            {
                connection.Close();
            }
        }
        static public int GetTotalPublishers()
        {
            byte TotalPublisher = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalPublishers = Count(PublisherID) from Publishers";

            SqlCommand command = new SqlCommand(query, connection);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
                {
                    TotalPublisher = ptCount;
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

            return TotalPublisher;
        }
        
    }
}

