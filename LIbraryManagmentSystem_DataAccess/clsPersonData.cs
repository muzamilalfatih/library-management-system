using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationlNO,ref string FirstName, ref string SecondName,
          ref string ThirdName, ref string LastName,
           ref int Gender, ref string Address, ref string Phone, ref string Email
            )
        {
            if (IsPersonExist(PersonID))
            {
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string query = "Select * FROM People WHERE PersonID = @PersonID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        NationlNO = (string)reader["NationalNo"];
                        FirstName = (string)reader["FirstName"];
                        SecondName = (string)reader["SecondName"];
                        if (reader["ThirdName"] != DBNull.Value)
                        {
                            ThirdName = (string)reader["ThirdName"];
                        }
                        else
                        {
                            ThirdName = "";
                        }
                        LastName = (string)reader["LastName"];
                        Gender = (int)reader["Gender"];
                        Address = (string)reader["Address"];
                        Phone = (string)reader["Phone"];
                        
                            Email = (string)reader["Email"];                     
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
            else
            {
                return false;
            }
        }
      
        public static int AddNewPerson(  string NationalNO, string FirstName,  string SecondName,
           string ThirdName,  string LastName,
            short Gender,  string Address,  string Phone,  string Email)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string prcedureName = @"sp_AddNewPerson";
            SqlCommand command = new SqlCommand(prcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "" && ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            command.Parameters.AddWithValue("@LastName", LastName);        
            
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
           
            command.Parameters.AddWithValue("@Email", Email);
            SqlParameter returnedValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
            returnedValue.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(returnedValue);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                PersonID = (int)returnedValue.Value;
            }
            catch
            (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }
        public static bool UpdatePerson(int PersonID, string NationalNO, string FirstName, string SecondName,
           string ThirdName, string LastName, 
           short Gender, string Address, string Phone, string Email
            )
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  People  
                            set NationalNo = @NationalNo,
                                FirstName = @FirstName, 
                                SecondName = @SecondName, 
                                ThirdName = @ThirdName, 
                                LastName = @LastName, 
                                                              
                                Gender = @Gender,
                                Address = @Address,
                                Phone = @Phone,
                                Email = @Email                            
                                

                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNO);    
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "" && ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            
            command.Parameters.AddWithValue("@Email", Email);
                 

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
        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Users.UserID,  FullName = People.FirstName +''+ People.SecondName+''+ ISNULL( People.ThirdName,'')+''+ People.LastName, \r\n\t\tUsers.UserName, \r\n\t\tUsers.UserRoles, Users.IsActive\r\nFROM     Users INNER JOIN\r\n                  People ON Users.PersonID = People.PersonID\t";
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
        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT PersonID FROM People WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static bool IsPersonExist(string NationalNo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT PersonID FROM People WHERE NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
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
        
    }
}
