using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsUserData
    {
        static public bool GetUeserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
           ref string Password,ref int Role, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Role = (int)reader["UserRoles"];
                    IsActive = (bool)reader["IsActive"];
                    IsFound = true;
                }
            }
            catch
            (Exception ex)
            {
                return IsFound;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        static public bool GetUserInfoByUserName(string UserName, ref int PersonID, ref int UserID,
           ref string Password, ref int Role, ref bool IsActive)
        {
            bool IsFound = false;

            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from users where UserName = @UserName ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
                
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    Role = (int)reader["UserRoles"];
                    IsActive = (bool)reader["IsActive"];
                    IsFound = true;
                }

            }
            catch
            (Exception ex)
            {
                clsEventLog.LogError(ex.ToString(),EventLogEntryType.Error);
                return IsFound;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
           
        }
        static public int AddNewUser(int PersonID, string UserName, string Password,byte Role, bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string procedureName = @"sp_AddNewUser";
            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserRoles", Role);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            SqlParameter returnedValue = new SqlParameter("@ReturnValue",SqlDbType.Int);
            returnedValue.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(returnedValue);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                UserID = (int)returnedValue.Value;
            }
            catch
            (Exception ex)
            {
                return UserID;
            }
            finally
            {
                connection.Close();
            }
            return UserID;
        }
        static public bool UpdateUser(int UserID, int PersonID, string UserName, string Password, byte Role, bool IsActive)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set PersonID = @PersonID, 
                                UserName = @UserName, 
                                Password = @Password,
                                UserRoles = @UserRoles,
                                IsActive = @IsActive 

                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserRoles", Role);
            command.Parameters.AddWithValue("@IsActive", IsActive);

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
        static public bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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
        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from Users_View";
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
        static public bool IsUserExist(int UserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT PersonID FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }
        static public bool IsUserExist(string UserName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT PersonID FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                clsEventLog.LogError(ex.ToString(), EventLogEntryType.Error);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }
        static public int GetTotalUsers()
        {
            byte TotalUsers = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalUsers = Count(UserID) from Users";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
                {
                    TotalUsers = ptCount;
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

            return TotalUsers;
        }
        static public bool IsThereOtherAdmins( int CurrentUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 Found = 1 from Users where not UserID = @CurrentUserID and  UserRoles = 0 and IsActive = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    IsFound = reader.HasRows; 
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

            return IsFound;
        }
        static public bool ChangePassword(int UserID, string Password)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set   Password = @Password                               
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);

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
    }
}
