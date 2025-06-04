using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsMembershipData
    {
        public static bool GetMemberShipInfoInfoByID(int MembershipID, ref int MemberID, ref int  MembershipClassID, ref DateTime MembershipStartDate, ref DateTime MembershipExpirationDate, ref float PaidFees, ref int CreatedByUserID)
        {
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM Memberships WHERE MembershipID = @MembershipID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MembershipID", MembershipID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MemberID = (int)reader["MemberID"];
                    MembershipClassID = (int)reader["MembershipClassID"];
                    MembershipStartDate = (DateTime)reader["MembershipStartDate"];
                    MembershipExpirationDate = (DateTime)reader["MembershipExpirationDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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
        public static bool GetMemberShipInfoInfoByMemberID(int MemberID, ref int MembershipID, ref int MembershipClassID, ref DateTime MembershipStartDate, ref DateTime MembershipExpirationDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select top 1 *   FROM Memberships WHERE MemberID = @MemberID
                             order by MembershipID desc";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MembershipID = (int)reader["MembershipID"];
                    MembershipClassID = (int)reader["MembershipClassID"];
                    MembershipStartDate = (DateTime)reader["MembershipStartDate"];
                    MembershipExpirationDate = (DateTime)reader["MembershipExpirationDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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
        public static int AddNewMembership( int MemberID, int MembershipClassID,  DateTime MembershipStartDate, DateTime MembershipExpirationDate, float PaidFees, int CreatedByUserID)
        {
            int MemberShipID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                INSERT INTO Memberships
           (
            MemberID
           ,MembershipClassID
           ,MembershipStartDate
           ,MembershipExpirationDate
           , PaidFees
           ,CreatedByUserID
           )
     VALUES
           (
            @MemberID,
            @MembershipClassID, 
           @MembershipStartDate, 
           @MembershipExpirationDate,
            @PaidFees,
            @CreatedByUserID
           );
            SELECT SCOPE_IDENTITY();
                ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@MembershipClassID", MembershipClassID);
            command.Parameters.AddWithValue("@MembershipStartDate", MembershipStartDate);
            command.Parameters.AddWithValue("@MembershipExpirationDate", MembershipExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewMemberShipID))
                {
                    MemberShipID = NewMemberShipID;
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
            return MemberShipID;
        }

        public static bool UpdateMembership(int MembershipID, int MemberID, int MembershipClassID, DateTime MembershipStartDate, DateTime MembershipEndDate, float PaidFees)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Memberships  
                            set MemberID = @MemberID, 
                                MembershipClassID = @MembershipClassID, 
                                MembershipStartDate = @MembershipStartDate,       
                                MembershipEndDate = @MembershipEndDate, 
                                PaidFees = @PaidFees 

                                where MembershipID = @MembershipID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@MembershipClassID", MembershipClassID);
            command.Parameters.AddWithValue("@MembershipStartDate", MembershipStartDate);
            command.Parameters.AddWithValue("@MembershipEndDate", MembershipEndDate);       
            command.Parameters.AddWithValue("@PaidFees", PaidFees);    
            command.Parameters.AddWithValue("@MembershipID", MembershipID);

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
        public static bool DeleteMembership(int MembershipID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Memberships WHERE MembershipID = @MembershipID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MembershipID", MembershipID);

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
