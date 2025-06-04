using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsBookCopyData
    {
        public static bool GetBookCopyInfoByID(int BookCopyID, ref int BookID, ref int ReservedForMemberID,
         ref bool IsAvailble, ref bool IsDamaged)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM BookCopies WHERE BookCopyID = @BookCopyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    BookID = (int )reader["BookID"];
                    if (reader["ReservedForMemberID"] != DBNull.Value)
                    {
                        ReservedForMemberID = (int)reader["ReservedForMemberID"];
                    }
                    IsAvailble = (bool)reader["IsAvailable"];
                    IsDamaged = (bool)reader["IsDamaged"];

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
        public static DataTable GetAllCopies(int BookID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from BookCopies Where BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", BookID);

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
        public static int AddNewBookCopy( int BookID, bool IsAvailble = true, bool IsDamaged = false)
        {
            int BookCopyID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                        INSERT INTO BookCopies
                   (
                   BookID
                   ,IsAvailble
                   ,IsDamaged
                   
                   
                   )
             VALUES
                   (
                    @BookID, 
                   @IsAvailble
                   @IsDamaged
                   
                   );
                    SELECT SCOPE_IDENTITY();
                ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", BookID);

            command.Parameters.AddWithValue("@IsAvailble", IsAvailble);
            command.Parameters.AddWithValue("@IsDamaged", IsDamaged);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewBookCopyID))
                {
                    BookCopyID = NewBookCopyID;
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
            return BookCopyID;
        }
        public static bool UpdateStatus (int BookCopyID, bool IsAvilable, bool IsDamaged)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  BookCopies                                 
                             Set    IsAvilable = @IsAvilable, 
                                    IsDamaged = @IsDamaged
                                where BookCopyID = @BookCopyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IsAvilable", IsAvilable);
            command.Parameters.AddWithValue("@IsDamaged", IsDamaged);
            command.Parameters.AddWithValue("@BookCopyID", BookCopyID);

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
        public static bool Reserve (int BookCopyID, int ReservedForMemberID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  BookCopies                                 
                             Set    RservedForMemberID = @RservedForMemberID
                                    
                                where BookCopyID = @BookCopyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
            command.Parameters.AddWithValue("@RservedForMemberID", ReservedForMemberID);

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
        public static bool IsReserved(int BookCopyID)
        {

            bool Result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select Found = 1 from BookCopies where BookCopyID = @BookCopyID and ReservedForMemberID is null";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null )
                {
                    Result = true;
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }


            return Result;
        }
        public static bool ReleseReservation(int BookCopyID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  BookCopies                                 
                             Set    ReservedForMemberID = NULL 
                                    
                                where BookCopyID = @BookCopyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookCopyID", BookCopyID);

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
        public static bool IsertNumberOfCopiesForBookID(int BookID, int NumberOFCopies, ref DataTable reservationsList)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string storedProcedureName = @"sp_AddNumberOfCopies";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BookID", BookID);
                command.Parameters.AddWithValue("@NumberOFCopies", NumberOFCopies);
                SqlParameter outPutParameter = new SqlParameter("@RowAffected", SqlDbType.Int); 
                outPutParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(outPutParameter);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reservationsList.Load(reader);
                        }
                    }
                    rowsAffected = (int)outPutParameter.Value;
                    
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    //connection.Close();
                }

                return rowsAffected > 0;
            }
        }
        static public bool ISReservationAvialbaleForBookID(int memberID, int bookID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select top 1 Found = 1 from BookCopies where BookID = @bookID and ReservedForMemberID = @memberID";
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

        public static int TotalCopies(int BookID)
        {

            byte TotalCopies = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" Select TotalCopies = Count(BookCopyID) from BookCopies where BookID = @BookID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Copies))
                {
                    TotalCopies = Copies;
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

            return TotalCopies;
        }
        public static int AvailbleCopies(int BookID)
        {

            byte TotalCopies = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" Select TotalCopies = Count(BookCopyID) from BookCopies 
                              where BookID = @BookID and IsAvailable = 1 and ReservedForMemberID is NULL and IsDamaged = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Copies))
                {
                    TotalCopies = Copies;
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

            return TotalCopies;
        }
        static public int GetTotalBooks()
        {
            int TotalBooks = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalBooks = count(BookCopyID) from BookCopies";

            SqlCommand command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Count))
                {
                    TotalBooks = Count;
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

            return TotalBooks;
        }
        public static bool RepairBookCopy(int bookCopyID, string Description,DateTime Date, float Cost, ref int ReservedForMemberID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string procedureName = @"sp_RepairBookCopy";

            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CopyID", bookCopyID);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Cost", Cost);
            SqlParameter returnedValue = new SqlParameter();
            returnedValue.Direction = ParameterDirection.ReturnValue;
            SqlParameter reservedFormemberID = new SqlParameter("@ReservedForMemberID", SqlDbType.Int);
            reservedFormemberID.Direction = ParameterDirection.Output;
            command.Parameters.Add(returnedValue);
            command.Parameters.Add(reservedFormemberID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                rowsAffected = (int)returnedValue.Value;
                ReservedForMemberID = (int)reservedFormemberID.Value;
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
