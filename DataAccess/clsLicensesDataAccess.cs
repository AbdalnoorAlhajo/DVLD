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
    public class clsLicensesDataAccess
    {
        public static bool IsLicenseExistByApplicationID(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found = 1 from Licenses 
                        where ApplicationID = @ApplicationID";

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
        public static bool IsLicenseExistByLicenseID(int LicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found = 1 from Licenses 
                        where LicenseID = @LicenseID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
        public static DataTable GetLocalLicensesView(int PersonID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                    FROM  Licenses INNER JOIN
                  LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
				  INNER join Drivers on Drivers.DriverID = Licenses.DriverID
				  inner join People on People.PersonID = Drivers.PersonID
				  where People.PersonID =  @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);


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
            return dataTable;

        }


        static public int GetLocalDrivingLicenseApplicationID(int LicenseID)
        {
            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
FROM     LocalDrivingLicenseApplications 
 inner join Applications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
 inner join Licenses on Licenses.ApplicationID = Applications.ApplicationID
 where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue
                ("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocalDrivingLicenseApplicationID = insertedID;
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


            return LocalDrivingLicenseApplicationID;
        }


        static public bool FindByApplicationID(ref int LicenseID, ref int ApplicationID, ref int DriverID
    , ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate
            , ref string Notes, ref decimal PaidFees, ref bool IsActive
            , ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Licenses where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    LicenseID = (int)reader["LicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClassID = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = (reader["Notes"] == DBNull.Value) ? "" : (string)reader["Notes"];
                    PaidFees = (decimal)reader["PaidFees"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsActive = (Convert.ToByte(reader["IsActive"]) == 1) ? true : false;


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

        static public bool FindByLicenseID(ref int LicenseID, ref int ApplicationID, ref int DriverID
, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate
    , ref string Notes, ref decimal PaidFees, ref bool IsActive
    , ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Licenses where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    LicenseID = (int)reader["LicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClassID = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = (reader["Notes"] == DBNull.Value) ? "" : (string)reader["Notes"];
                    PaidFees = (decimal)reader["PaidFees"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsActive = (Convert.ToByte(reader["IsActive"]) == 1) ? true : false;


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

        public static int AddLicense(int ApplicationID, int DriverID
    , int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes
            , decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {

            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Licenses(ApplicationID, DriverID, LicenseClass
, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
 VALUES  (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate
, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);

            if (string.IsNullOrEmpty(Notes))
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
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


            return LicenseID;
        }


        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID
    , int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes
            , decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection
                (clsDataAccessSettings.ConnectionString);

            string query = @"Update  Licenses  
                            set ApplicationID = @ApplicationID,
                                DriverID = @DriverID, 
                                LicenseClass = @LicenseClassID, 
                                IssueDate = @IssueDate,
                                ExpirationDate = @ExpirationDate, 
                                Notes = @Notes, 
                                PaidFees = @PaidFees, 
                                IsActive = @IsActive, 
                                IssueReason = @IssueReason, 
                                CreatedByUserID = @CreatedByUserID
                                where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@IsActive", (IsActive) ? 1 : 0);

            if (string.IsNullOrEmpty(Notes))
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

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
