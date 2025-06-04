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
    public class clsBookData
    {
        public static bool GetBookInfoByID(int BookID, ref string Title, ref int AuthorID,
         ref string ISBN, ref int PublisherID,
          ref int  CategoryID, ref DateTime Year, ref string Location, ref float BorrowFees
           )
        {
            
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string query = "Select * FROM Books WHERE BookID = @BookID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookID", BookID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    { 
                        Title = (string)reader["Title"];
                        AuthorID = (int)reader["AuthorID"];                       
                        ISBN = (string)reader["ISBN"];
                        PublisherID = (int)reader["PublisherID"];
                        CategoryID = (int)reader["CategoryID"];
                        Year = (DateTime)reader["Year"];
                        
                        Location = (string)reader["Location"];
                        BorrowFees = Convert.ToSingle(reader["BorrowFees"]);
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
        public static bool GetBookInfoByTitle(ref string Title, ref int BookID, ref int AuthorID,
         ref string ISBN, ref int PublisherID,
          ref int CategoryID, ref DateTime Year, ref string Location, ref float BorrowFees
           )
            {

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string query = "Select * FROM Books WHERE Title = @Title";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", Title);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        BookID = (int)reader["BookID"];
                        Title = (string)reader["Title"];
                        AuthorID = (int)reader["AuthorID"];
                        ISBN = (string)reader["ISBN"];
                        PublisherID = (int)reader["PublisherID"];
                        CategoryID = (int)reader["CategoryID"];
                        Year = (DateTime)reader["Year"];

                        Location = (string)reader["Location"];
                        BorrowFees = Convert.ToSingle(reader["BorrowFees"]);
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
        public static bool GetBookInfoByISBN(ref string  ISBN, ref int BookID, ref int AuthorID,
         ref string Title, ref int PublisherID,
          ref int CategoryID, ref DateTime Year, ref string Location, ref float BorrowFees
           )
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM Books WHERE ISBN = @ISBN";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    BookID = (int)reader["BookID"];
                    AuthorID = (int)reader["AuthorID"];
                    Title = (string)reader["Title"];
                    ISBN = (string)reader["ISBN"];
                    PublisherID = (int)reader["PublisherID"];
                    CategoryID = (int)reader["CategoryID"];
                    Year = (DateTime)reader["Year"];

                    Location = (string)reader["Location"];
                    BorrowFees = Convert.ToSingle(reader["BorrowFees"]);
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
        public static int AddNewBook(  string Title,  int AuthorID,
          string ISBN,  int PublisherID,
           int CategoryID,  DateTime Year,  string Location, float BorrowFees, int NumberOfCopies)
        {
            int BookID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"sp_AddNewBook";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublisherID", PublisherID);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@TheNumberOfCopies", NumberOfCopies);
            command.Parameters.AddWithValue("@Location", Location);
            command.Parameters.AddWithValue("@BorrowFees", BorrowFees);
            SqlParameter returnedValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
            returnedValue.Direction = ParameterDirection.ReturnValue;
            SqlParameter RowAffected = new SqlParameter("@TheRowAffected ", SqlDbType.Int);
            RowAffected.Direction = ParameterDirection.Output;
            command.Parameters.Add(returnedValue);
            command.Parameters.Add(RowAffected);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                BookID = (int)returnedValue.Value;
            }
            catch
            (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return BookID;
        }
        public static bool UpdateBook(int BookID, string Title, int AuthorID,
          string ISBN, int PublisherID,
           int CategoryID, DateTime Year, string Location)
        {
            int  rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Books  
                            set Title = @Title, 
                                AuthorID = @AuthorID, 
                                ISBN = @ISBN, 
                                PublisherID = @PublisherID,                                                              
                                CategoryID = @CategoryID,
                                Year = @Year,                              
                                Location = @Location                                                                               
                                where BookID = @BookID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);
            
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@Year", Year);

            command.Parameters.AddWithValue("@PublisherID", PublisherID);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);


            command.Parameters.AddWithValue("@Location", Location);


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
        public static bool DeleteBook(int BookID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Books WHERE BookID = @BookID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

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
        static public DataTable GetAllBooks()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from Book_View";
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
        static public DataTable GetAllBooksForPublisher(int publisherID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Book_View.*
                                FROM     Books INNER JOIN
                                                  Publishers ON Books.PublisherID = Publishers.PublisherID INNER JOIN
                                                  Book_View ON Books.BookID = Book_View.BookID
                                where Publishers.PublisherID = @publisherID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@publisherID", publisherID);

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
        static public DataTable GetAllBooksForAuthor(int auhotrID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Book_View.*
                                FROM     Authors INNER JOIN
                                                  Books ON Authors.AuthorID = Books.AuthorID INNER JOIN
                                                  Book_View ON Books.BookID = Book_View.BookID
                                where Authors.AuthorID = @auhotrID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@auhotrID", auhotrID);

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

