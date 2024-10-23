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
    public class clsLocalApplicationsDataAccess
    {
        static public DataTable GetAllLocalApplicationsName()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select  ClassName from LocalDrivingLicenseApplications";

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

        static public DataTable GetAllDataForManageLocalApplications()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LocalDrivingLicenseApplications_View";

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

        static public int GetPassedTest(int LocalDrivingLicenseApplicationID)
        {
            int PassedTests = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  COUNT(Tests.TestResult)
FROM     LocalDrivingLicenseApplications INNER JOIN
                  TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                  Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID and TestResult = 1
				  where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID 
                    = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue
                ("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PassedTests = insertedID;
                }
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


            return PassedTests;
        }

        public static bool IsLocalApplicationExists(int ApplicantPersonID
            , int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found = 1
FROM     Applications INNER JOIN
                  LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
				  where ApplicantPersonID = @ApplicantPersonID
                and LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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

        public static bool DeleteApplication(int ApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete LocalDrivingLicenseApplications 
                           where LocalDrivingLicenseApplicationID = @LAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LAppID", ApplicationID);

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

        static public bool FindLocalApplicationByApplicationID(int ApplicationID
, ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LocalDrivingLicenseApplications
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;
                    LicenseClassID = (int)reader["LicenseClassID"];

                    LocalDrivingLicenseApplicationID =
                        (int)reader["LocalDrivingLicenseApplicationID"];
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

        static public bool FindLocalApplicationByLocalApplicationID(ref int ApplicationID
, int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LocalDrivingLicenseApplications
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID"
                , LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;
                    LicenseClassID = (int)reader["LicenseClassID"];

                    ApplicationID =
                        (int)reader["ApplicationID"];
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

        public static int AddNewApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenceApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications
(ApplicationID, LicenseClassID) VALUES  (@ApplicationID, @LicenseClassID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocalDrivingLicenceApplicationID = insertedID;
                }
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

    }
}
