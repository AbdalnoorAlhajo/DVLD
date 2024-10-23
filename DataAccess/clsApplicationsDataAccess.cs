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
    public class clsApplicationsDataAccess
    {

        static public bool FindApplicationByID(ref int ApplicationID, ref int ApplicantID
 , ref DateTime ApplicationDate, ref int ApplicationTypeID, ref DateTime ApplicationStatusDate
            , ref decimal PaidFees, ref int CreatedByUserID, ref int ApplicationStatus)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Applications where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    ApplicantID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationStatusDate = (DateTime)reader["LastStatusDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    ApplicationStatus = Convert.ToInt32(reader["ApplicationStatus"]);
                    PaidFees = (decimal)reader["PaidFees"];


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

        static public DataTable GetAllApplications()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Applications";

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

        public static int AddNewApplication(int ApplicantPersonID
 , DateTime ApplicationDate, int ApplicationTypeID, DateTime LastStatusDate
            , decimal PaidFees, int CreatedByUserID, int ApplicationStatus)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications(ApplicantPersonID, ApplicationStatus
, ApplicationDate, ApplicationTypeID, LastStatusDate, PaidFees, CreatedByUserID)
 VALUES  (@ApplicantPersonID, @ApplicationStatus, @ApplicationDate, @ApplicationTypeID
, @LastStatusDate, @PaidFees, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }

            catch (SqlException sqlEx)
            {
                clsUtil.SaveToEventLog(sqlEx.Message
                    , System.Diagnostics.EventLogEntryType.Error);
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


            return ApplicationID;
        }

        public static bool UpdateApplicationStatus(int ApplicationID, int ApplicationStatus)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Applications  
                            set ApplicationStatus = @ApplicationStatus
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool IsNewApplication(int ApplicantPersonID, int ApplicationTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found=1 from Applications where ApplicantPersonID = @ApplicantPersonID 
                                and ApplicationStatus = 1 and ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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
            return isFound;
        }

        public static bool IsApplicationExists(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found=1 from Applications where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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
            return isFound;
        }

        public static bool UpdateApplication(int ApplicationID, int ApplicantID
 , DateTime ApplicationDate, int ApplicationTypeID, DateTime ApplicationStatusDate
            , decimal PaidFees, int CreatedByUserID, int ApplicationStatus)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Applications  
                            set ApplicantID = @ApplicantID,
                                ApplicationStatusDate = @ApplicationStatusDate, 
                                ApplicationStatus = @ApplicationStatus, 
                                ApplicationDate = @ApplicationDate, 
                                PaidFees = @PaidFees, 
                                CreatedByUserID = @CreatedByUserID, 
                                ApplicationTypeID = @ApplicationTypeID
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantID", ApplicantID);
            command.Parameters.AddWithValue("@ApplicationStatusDate", ApplicationStatusDate);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool DeleteApplication(int ApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Applications 
                           where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

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

            return (rowsAffected > 0);


        }
    }
}
