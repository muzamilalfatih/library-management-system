using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsMembershipClassesData
    {
        public static bool GetMemberShipClassInfoInfo( int MembershipClassID, ref string MembershipClassName, ref int MaxNumberOfBooksCanBorrow, ref float FeesPerDay)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM MembershipClasses WHERE MembershipClassID = @MembershipClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MembershipClassID", MembershipClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MembershipClassName = (string)reader["MembershipClassName"];
                    MaxNumberOfBooksCanBorrow = (int)reader["MaxNumberOfBooksCanBorrow"];
                    FeesPerDay = Convert.ToSingle(reader["FeesPerDay"]);
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
        public static bool GetMemberShipClassInfoInfo( string MembershipClassName, ref int MembershipClassID,  ref int MaxNumberOfBooksCanBorrow, ref float FeesPerDay)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM MembershipClasses WHERE MembershipClassName = @MembershipClassName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MembershipClassName", MembershipClassName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MembershipClassID = (int)reader["MembershipClassID"];
                    MaxNumberOfBooksCanBorrow = (int)reader["MaxNumberOfBooksCanBorrow"];
                    FeesPerDay = Convert.ToSingle(reader["FeesPerDay"]);
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
        public static int AddNewMembershipClass(string MembershipClassName, int MaxNumberOfBooksCanBorrow, float FeesPerDay)
        {
            int MemberShipClassID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                INSERT INTO MembershipClasses
           (
           MembershipClassName
           ,MaxNumberOfBooksCanBorrow
           ,FeesPerDay
           )
     VALUES
           (
            @MembershipClassName, 
           @MaxNumberOfBooksCanBorrow, 
           @FeesPerDay
           );
            SELECT SCOPE_IDENTITY();
                ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MembershipClassName", MembershipClassName);
            command.Parameters.AddWithValue("@MaxNumberOfBooksCanBorrow", MaxNumberOfBooksCanBorrow);
            command.Parameters.AddWithValue("@FeesPerDay", FeesPerDay);          

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewMemberShipClassID))
                {
                    MemberShipClassID = NewMemberShipClassID;
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
            return MemberShipClassID;
        }
        public static bool UpdateMembership(int MembershipClassID, string MembershipClassName, int MaxNumberOfBooksCanBorrow, float FeesPerDay)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  MembershipClasses  
                            set MembershipClassName = @MembershipClassName, 
                                MaxNumberOfBooksCanBorrow = @MaxNumberOfBooksCanBorrow, 
                                FeesPerDay = @FeesPerDay 

                                where MembershipClassID = @MembershipClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MembershipClassName", MembershipClassName);
            command.Parameters.AddWithValue("@MaxNumberOfBooksCanBorrow", MaxNumberOfBooksCanBorrow);
            command.Parameters.AddWithValue("@FeesPerDay", FeesPerDay);
            
            command.Parameters.AddWithValue("@MembershipClassID", MembershipClassID);

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
        public static bool DeleteMembershipClass(int MembershipClassID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM MembershipClasses WHERE MembershipClassID = @MembershipClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MembershipClassID", MembershipClassID);

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
        public static string GetMembershipClassName(int MembershipClassID)
        {
            string membershipClassName = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select MembershipClassName from MembershipClasses where MembershipClassID = @MembershipClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MembershipClassID", MembershipClassID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null )
                {
                    membershipClassName = result.ToString();
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
            return membershipClassName;
        }
        public static int GetMembershipClassID(string MembershipClassName)
        {
            int membershipClassID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select MembershipClassID  from MembershipClasses where MembershipClassName = @MembershipClassName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MembershipClassName", MembershipClassName);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Result))
                {
                   membershipClassID = Result;
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
            return membershipClassID;
        }
        public static DataTable GetAllMembershipClassess()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from  MembershipClasses";
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
