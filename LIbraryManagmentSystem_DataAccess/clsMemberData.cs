using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsMemberData
    {
        public static bool GetMemberInfoByID(int MemberID, ref int PersonID,ref DateTime CreatedDate,ref bool IsActive, ref int CreatedByUserID)
        {
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM Members WHERE MemberID = @MemberID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                    return true;
                }
                return false;
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
            
        public static int AddNewMember(  int PersonID,DateTime CreatedDate,bool IsActive, int CreatedByUserID)
        {
            int MemberID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                INSERT INTO Members
           (
           PersonID
           ,CreatedByUserID 
            ,CreatedDate
            ,IsActive
           )
     VALUES
           (
            @PersonID, 
            @CreatedByUserID,
            @CreatedDate,
            @IsActive
           );
            SELECT SCOPE_IDENTITY();
                ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);                
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewMemberID))
                {
                    MemberID = NewMemberID;
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
            return MemberID;
        }
        public static bool UpdateMember(int MemberID, bool IsActive)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Members  
                            set  IsActive = @IsActive 
                                where MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@MemberID", MemberID);


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
        public static DataTable GetAllMembers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Members_View order by MemberID";
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
        public static bool DeleteMember(int MemberID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Members WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

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
        public static bool IsMemberExist(int MemberID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT MemberID FROM People WHERE MemberID = @MemberID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
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
        static public int GetTotalMembers()
        {
            int TotalMembers = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalMembers = count(MemberID) from Members";

            SqlCommand command = new SqlCommand(query, connection);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Count))
                {
                    TotalMembers = Count;
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

            return TotalMembers;
        }
    }
}
