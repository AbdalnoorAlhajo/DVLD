using DataAccessSettings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class clsCountryDataAccess
    {
        static public DataTable GetAllCountriesName()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select CountryName from countries";

            SqlCommand command = new SqlCommand(query, connection);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    dataTable.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                clsUtil.SaveToEventLog(ex.Message
                  , System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }
            return dataTable; // function not implemeted yet
        }

        public static bool Find( ref int CountryID
            , ref string CountryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CountryID = (int)reader["CountryID"];
                    CountryName = (string)reader["CountryName"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                clsUtil.SaveToEventLog(ex.Message
                    , System.Diagnostics.EventLogEntryType.Error);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
