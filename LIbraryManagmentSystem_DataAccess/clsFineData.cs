using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsFineData
    {
        public static bool GetFineInfoByBorrowID( int FineID, ref int MemberID, ref int  BorrowID, ref float FineAmount,
          ref float  PaidAmount, ref bool IsPaid,
           ref DateTime FineDate,ref int FineReason
            )
        {
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Fines Where FineID = @FineID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FineID", FineID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MemberID = (int)reader["MemberID"];
                    BorrowID = (int)reader["BorrowID"];
                    FineAmount = Convert.ToSingle(reader["FineAmount"]);
                    PaidAmount = Convert.ToSingle(reader["PaidAmount"]);
                    IsPaid = (bool)reader["IsPaid"];
                    FineDate = (DateTime)reader["FineDate"];
                    FineReason = (int)reader["Reason"];
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

     //   public static int AddNewFine(int MemberID,  int BorrowID,  float FineAmount,
     //        bool IsPaid = false
     //       )
     //   {
     //       int FineID = -1;
     //       SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
     //       string query = @"
     //           INSERT INTO Fine
     //      (
     //      MemberID
     //      ,BorrowID
     //      ,FineAmount
     //       ,IsPaid
           
     //      )
     //VALUES
     //      (
     //       @MemberID, 
     //      @BorrowID, 
     //      @FineAmount, 
     //       @IsPaid
          
     //      );
     //       SELECT SCOPE_IDENTITY();
     //           ";
     //       SqlCommand command = new SqlCommand(query, connection);
     //       command.Parameters.AddWithValue("@MemberID", MemberID);
     //       command.Parameters.AddWithValue("@BorrowID", BorrowID);
     //       command.Parameters.AddWithValue("@FineAmount", FineAmount);
     //       command.Parameters.AddWithValue("@IsPaid", IsPaid);
     //       try
     //       {
     //           connection.Open();
     //           object result = command.ExecuteScalar();

     //           if (result != null && int.TryParse(result.ToString(), out int NewFineID))
     //           {
     //               FineID = NewFineID;
     //           }
     //       }
     //       catch
     //       (Exception ex)
     //       {

     //       }
     //       finally
     //       {
     //           connection.Close();
     //       }
     //       return FineID;
     //   }
        public static bool PayFine( int FineID, int PaidByUserID, float PaidAmount)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"sp_PayFine";

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FineID", FineID);
            command.Parameters.AddWithValue("@PaidByUserID", PaidByUserID);          
            command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            SqlParameter returnedValue = new SqlParameter("@ReturnValue",SqlDbType.Int);
            returnedValue.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(returnedValue);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();
                rowsAffected = (int)returnedValue.Value;
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
        public static bool DoesMemberHasUnpaidFine( int MemberID )
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT FineID FROM Fines WHERE MemberID = @MemberID and IsPaid = 0";
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
        static public DataTable GetAllFines()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * from Fines_View";
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
                
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
    

