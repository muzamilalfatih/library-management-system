using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsReservationData
    {
        public static bool GetReservationInfoInfoByID(int ReservationID, ref int MemberID, ref int BookID, ref DateTime ReservationDate, 
            ref byte ReservationStaus, ref int CreatedByUserID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM Reservations WHERE ReservationID = @ReservationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReservationID", ReservationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MemberID = (int)reader["MemberID"];
                    BookID = (int)reader["BookID"];
                    ReservationDate = (DateTime)reader["ReservationDate"];
                    ReservationStaus = (byte)reader["ReservationStaus"];
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
        public static int GetReservationID( int BookID,  int MemberID)
        {
            int reservationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select ReservationID FROM Reservations WHERE MemberID = @MemberID and BookID = @BookID and ReservationStatus = 2";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@BookID", BookID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int returnedID))
                {
                    reservationID = returnedID;
                }
                return reservationID;
            }
            catch
            (Exception ex)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int AddNewReservation(  int MemberID,  int BookID,  int CreatedByUserID)
        {
            int ReservationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                INSERT INTO Reservations
                   (
                   MemberID
                   ,BookID
                   ,CreatedByUserID
           
                   )
                     VALUES
                   (
                    @MemberID, 
                   @BookID,
                    @CreatedByUserID
                   );
            SELECT SCOPE_IDENTITY();
                ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
 

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewReservationID))
                {
                    ReservationID = NewReservationID;
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
            return ReservationID;
        }
        public static bool UpdateReservation(int ReservationID, int MemberID, int BookID, DateTime ReservationDate,
             byte ReservationStaus, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Reservations
                            set MemberID = @MemberID, 
                                MemberID = @MemberID, 
                                BookID = @BookID, 
                                ReservationDate = @ReservationDate,
                                ReservationStaus @ReservationStaus
                                CreatedByUserID = @CreatedByUserID
                  

                                where ReservationID = @ReservationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
            command.Parameters.AddWithValue("@ReservationStaus", ReservationStaus);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


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
        public static bool DeleteReservation(int ReservationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Reservations WHERE ReservationID = @ReservationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);

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
        public static bool CancelReservation (int reservationID , ref int reservedForMemberID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string procedureName = @"sp_CancelReservation";

            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ReservationID", reservationID);
           SqlParameter returnedValue = new SqlParameter();
            returnedValue.Direction = ParameterDirection.ReturnValue;
            SqlParameter ReservedForMemberID = new SqlParameter("@ReservedForMemberID", SqlDbType.Int);
            ReservedForMemberID.Direction = ParameterDirection.Output;
            command.Parameters.Add(returnedValue);
            command.Parameters.Add(ReservedForMemberID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery ();
                rowsAffected = (int)returnedValue.Value;
                if (ReservedForMemberID != null)
                {
                    reservedForMemberID = (int)ReservedForMemberID.Value;
                }
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
        static public bool DoesHasActiveReservationForBookID(int memberID, int bookID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select Found = 1 from Reservations where BookID = @bookID and MemberID = @memberID and  ReservationStatus not in (3,4)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@memberID", memberID);
            command.Parameters.AddWithValue("@bookID", bookID);
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
        static public DataTable GetAllReservations()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from Reservations_View";
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
