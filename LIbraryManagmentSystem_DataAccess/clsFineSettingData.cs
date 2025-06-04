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
    public class clsFineSettingData
    {

        public static DataTable GetFineSettingsInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Select * from LibrarySettings";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                clsEventLog.LogError(ex.ToString(), EventLogEntryType.Error);
            }
            return dt; 
        }
        public static bool UpdateFineSettings( DataTable dtFineSettings)
        {
            int rowsAffected = 0;
            float FineAmountPerDay = Convert.ToSingle(dtFineSettings.Rows[0]["FineAmountPerDay"].ToString());
            float FineForDamagedBook = Convert.ToSingle(dtFineSettings.Rows[0]["FineForDamagedBook"].ToString());
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" UPDATE LibrarySettings
                               SET FineAmountPerDay = @FineAmountPerDay,
                                  FineForDamagedBook =@FineForDamagedBook";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FineAmountPerDay", FineAmountPerDay);
            command.Parameters.AddWithValue("@FineForDamagedBook", FineForDamagedBook);         

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
