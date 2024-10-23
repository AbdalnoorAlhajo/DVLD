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
    public class clsApplicationTypesDataAccess
    {
        static public DataTable GetAllApplicationTypes()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from ApplicationTypes";

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

        static public bool FindApplicationTypeByID(ref int ApplicationTypeID
            , ref string ApplicationTypeTitle, ref Decimal ApplicationFees)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from ApplicationTypes
                where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToDecimal(reader["ApplicationFees"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                clsUtil.SaveToEventLog(ex.Message
                 , System.Diagnostics.EventLogEntryType.Error);
                isExists = false;

            }
            finally
            {
                connection.Close();
            }
            return isExists;
        }


        static public bool FindApplicationTypeByName(ref int ApplicationTypeID
    , ref string ApplicationTypeTitle, ref Decimal ApplicationFees)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from ApplicationTypes
                where ApplicationTypeTitle = @ApplicationTypeTitle";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationFees = Convert.ToDecimal(reader["ApplicationFees"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                clsUtil.SaveToEventLog(ex.Message
    , System.Diagnostics.EventLogEntryType.Error);
                isExists = false;

            }
            finally
            {
                connection.Close();
            }
            return isExists;
        }

        public static bool UpdateApplicationType(int ApplicationTypeID
            , string ApplicationTypeTitle, Decimal ApplicationFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  ApplicationTypes  
                            set ApplicationTypeTitle = @ApplicationTypeTitle,
                                ApplicationFees = @ApplicationFees
                                where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsUtil.SaveToEventLog(ex.Message
    , System.Diagnostics.EventLogEntryType.Error);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}
