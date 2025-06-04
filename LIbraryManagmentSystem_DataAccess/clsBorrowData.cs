using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsBorrowData
    {
        public static bool GetBorrowInfoByID(int BorrowID, ref int  MemberID, ref int CopyID,
         ref DateTime BorrowDate, ref DateTime DueDate,
          ref float PaidFees, ref string ReturnNotes, ref DateTime ReturnDate,
          ref float ReturnFees, ref int CreatedByUserID,ref int ReturnedByUserID
           )
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM Borrows WHERE BorrowID = @BorrowID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowID", BorrowID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MemberID = (int)reader["MemberID"];
                    CopyID = (int)reader["CopyID"];
                    BorrowDate = (DateTime)reader["BorrowDate"];
                    DueDate = (DateTime)reader["DueDate"];
                    PaidFees = (float)reader["PaidFees"];
                    if (reader["ReturnNotes"] == DBNull.Value)
                        ReturnNotes = "";
                    else
                        ReturnNotes = (string)reader["ReturnNotes"];
                    if (reader["ReturnDate"] == DBNull.Value)
                        ReturnDate = DateTime.Now;
                    else
                        ReturnDate = (DateTime)reader["ReturnDate"];
                    if (reader["ReturnFees"] == DBNull.Value)
                        ReturnFees = 0;
                    else
                        ReturnFees = (float)reader["ReturnFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["ReturnedByUserID"] == DBNull.Value)
                        ReturnedByUserID = -1;
                    else
                        ReturnedByUserID = (int)reader["ReturnedByUserID"];
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
        public static bool GetBorrowInfoByCopyID(int CopyID , ref int BorrowID , ref int MemberID,
         ref DateTime BorrowDate, ref DateTime DueDate,
          ref float PaidFees , ref int CreatedByUserID, ref string ReturnNotes, ref DateTime? ReturnDate,
          ref float ReturnFees, ref int ReturnedByUserID
           )
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM Borrows WHERE CopyID = @CopyID  order by BorrowID desc";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    BorrowID = (int)reader["BorrowID"];
                    MemberID = (int)reader["MemberID"];
                    BorrowDate = (DateTime)reader["BorrowDate"];
                    DueDate = (DateTime)reader["DueDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["ReturnNotes"] == DBNull.Value)
                        ReturnNotes = null;
                    else
                        ReturnNotes = (string)reader["ReturnNotes"];
                    if (reader["ReturnDate"] == DBNull.Value)
                        ReturnDate = null;
                    else
                        ReturnDate = (DateTime)reader["ReturnDate"];
                    if (reader["ReturnFees"] == DBNull.Value)
                        ReturnFees = 0;
                    else
                        ReturnFees = Convert.ToSingle(reader["ReturnFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["ReturnedByUserID"] == DBNull.Value)
                        ReturnedByUserID = -1;
                    else
                        ReturnedByUserID = (int)reader["ReturnedByUserID"];

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
        public static int AddNewBorrow( int MemberID,  int BookID,
          DateTime BorrowDate,  DateTime DueDate,float PaidFees,int CreatedByUserID,bool HasReservation, ref int CopyID)
        {
            int borrowID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string procedureName = @"sp_BorrowBook";
            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@HasReservation", HasReservation);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@DueDate", DueDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            SqlParameter copyIDOutPutParameter = new SqlParameter("@CopyID", SqlDbType.Int);
            copyIDOutPutParameter.Direction = ParameterDirection.Output;
            command.Parameters.Add(copyIDOutPutParameter);
            SqlParameter borrowIDOutPutParameter = new SqlParameter("@BorrowID", SqlDbType.Int);
            borrowIDOutPutParameter.Direction = ParameterDirection.Output;
            command.Parameters.Add(borrowIDOutPutParameter);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                borrowID = (int)borrowIDOutPutParameter.Value;
                CopyID = (int)copyIDOutPutParameter.Value;
            }
            catch
            (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return borrowID;
        }
        public static bool UpdateBorrow(int BorrowID, int MemberID, int BookID,
          DateTime BorrowDate, DateTime DueDate, float PaidFees, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Borrows  
                            set MemberID = @MemberID, 
                                BookID = @BookID, 
                                BorrowDate = @BorrowDate, 
                                DueDate = @DueDate,                                                              
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID,
                                CopiesAvilable = @CopiesAvilable                                                                              
                                where BorrowID = @BorrowID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowID", BorrowID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@BorrowDate", BorrowDate);
            command.Parameters.AddWithValue("@DueDate", DueDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
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
        public static bool ReturnBook(int BorrowID, string ReturnNote, ref float ReturnFees, ref int ReservedForMemberID, int ReturnedByUserID, bool IsDamaged)
        {
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"sp_ReturnBook";

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IsDamaged", IsDamaged);
            command.Parameters.AddWithValue("@BorrowID", BorrowID);
            command.Parameters.AddWithValue("@ReturnNote", ReturnNote);
            command.Parameters.AddWithValue("@ReturnedByUserID", ReturnedByUserID);
            SqlParameter returnFees = new SqlParameter("@TotalReturnFees", SqlDbType.Float);
            returnFees.Direction = ParameterDirection.Output;
            SqlParameter reservedForMemberID = new SqlParameter("@ReservedForMemberID", SqlDbType.Int);
            reservedForMemberID.Direction = ParameterDirection.Output;

            command.Parameters.Add(returnFees);
            command.Parameters.Add(reservedForMemberID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                if (reservedForMemberID.Value !=DBNull.Value)
                {
                    ReservedForMemberID = (int)reservedForMemberID.Value;
                }
                else
                {
                    ReservedForMemberID = -1;
                }

                ReturnFees = Convert.ToSingle(returnFees.Value);
                return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
            
        }
        static public int GetTotalIssuedBooks()
        {
            int TotalIssuedBooks = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalIssuedBooks = count(BorrowID) from Borrows where ReturnDate is Null;";

            SqlCommand command = new SqlCommand(query, connection);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Count))
                {
                    TotalIssuedBooks = Count;
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

            return TotalIssuedBooks;
        }
        static public int GetTotalBorrowedBook(int MemberID)
        {
            int totalBorrowedBooks = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select count(BorrowID) as TotalBorrowedBooks from Borrows where MemberID = @MemberID and ReturnDate is NULL";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Count))
                {
                    totalBorrowedBooks = Count;
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

            return totalBorrowedBooks;
        }
         static public DataTable GetAllBorrows()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from Borrows_View";
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
