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
    public class clsTestAppointmentsDataAccess
    {
        static public DataTable GetAllTestAppointmentsView
            (int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TestAppointmentID as AppointmentID
                , AppointmentDate, PaidFees, IsLocked from TestAppointments
        where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                And TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue
                ("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        static public DateTime GetDateTime(int TestAppointmentID)
        {
            DateTime TestAppointmentDate = DateTime.Now;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select AppointmentDate from TestAppointments
                                    where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestAppointmentDate = Convert.ToDateTime(reader[0]);
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

            return TestAppointmentDate;
        }

        static public int GetLastTestAppointmentID(int LocalDrivingLicenseApplicationID
            , int TestTypeID)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select  top 1 TestAppointmentID  from TestAppointments
            where LocalDrivingLicenseApplicationID  = @LocalDrivingLicenseApplicationID
                    and TestTypeID = @TestTypeID  
                    order by TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue
                ("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestAppointmentID = (int)reader[0];
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

            return TestAppointmentID;
        }


        static public bool FindTestAppointmentByTestAppointmentID(
             int TestAppointmentID, ref int TestTypeID
            , ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate
            , ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestAppointments
                            where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    LocalDrivingLicenseApplicationID =
                        (int)reader["LocalDrivingLicenseApplicationID"];

                    IsLocked = (Convert.ToInt32(reader["IsLocked"]) == 1) ? true : false;
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


        static public int GetTrails(int LocalDrivingLicenseApplicationID
            , int TestTypeID)
        {
            int PassedTests = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select COUNT(TestAppointmentID) from TestAppointments
where IsLocked = 1 and TestTypeID = @TestTypeID 
and LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue
                ("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        static public int AddNewAppointment(int TestTypeID
            , int LocalDrivingLicenseApplicationID, DateTime AppointmentDate
            , decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments(TestTypeID
, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked) 
VALUES 
(@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees,
@CreatedByUserID, @IsLocked);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue
                ("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked ? 1 : 0);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
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


            return TestAppointmentID;
        }


        public static bool UpdateAppointment(int TestAppointmentID, int TestTypeID
            , int LocalDrivingLicenseApplicationID, DateTime AppointmentDate
            , decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  TestAppointments  
                            set AppointmentDate = @AppointmentDate,
                                IsLocked = @IsLocked, 
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID,
                 LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID, 
                                TestTypeID = @TestTypeID
                                where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID"
                , LocalDrivingLicenseApplicationID);

            command.Parameters.AddWithValue("@IsLocked", IsLocked ? 1 : 0);

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


        public static bool IsTestAppointmentTaken(int TestAppointmentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found = 1 FROM TestAppointments
    where TestAppointmentID = @TestAppointmentID and IsLocked = 1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

        public static bool IsTestAppointmentExist(int TestTypeID
            , int LocalDrivingLicenseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found = 1 FROM TestAppointments
    where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                        and TestTypeID = @TestTypeID and IsLocked = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue
                ("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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

    }
}
