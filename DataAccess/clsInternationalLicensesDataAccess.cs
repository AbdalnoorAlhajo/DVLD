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
    public class clsInternationalLicensesDataAccess
    {
        public static int AddLicense(int ApplicationID, int DriverID
            , int IssuedUsingLocalLicenseID, DateTime IssueDate
            , DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {

            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO InternationalLicenses(ApplicationID, DriverID
, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,IsActive, CreatedByUserID)
 VALUES  (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate
, @ExpirationDate, @IsActive, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue
                ("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InternationalLicenseID = insertedID;
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


            return InternationalLicenseID;
        }


        public static DataTable GetInternationalLicenseView(int PersonID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT InternationalLicenseID as 'IntLicenseID', InternationalLicenses.ApplicationID
, IssuedUsingLocalLicenseID as 'L.LicenseID', IssueDate, ExpirationDate, IsActive
FROM     InternationalLicenses 
inner join Applications on Applications.ApplicationID = InternationalLicenses.ApplicationID
where Applications.ApplicantPersonID = @PersonID";

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

        public static DataTable GetAllInternationalLicensesView()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT InternationalLicenseID as 'IntLicenseID', InternationalLicenses.ApplicationID
, InternationalLicenses.DriverID, IssuedUsingLocalLicenseID as 'L.LicenseID', IssueDate, ExpirationDate
, IsActive  FROM     InternationalLicenses 
inner join Applications on Applications.ApplicationID = InternationalLicenses.ApplicationID";

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
            return dataTable;

        }


        public static bool IsLicenseExistByLicenseID(int IssuedUsingLocalLicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found = 1 from InternationalLicenses 
                        where IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue
                ("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

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


        static public bool Find(ref int InternationalLicenseID, ref int ApplicationID
            , ref int DriverID, ref int IssuedUsingLocalLicenseID
            , ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive
                 , ref int CreatedByUserID)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from InternationalLicenses
                                where InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID"
                , InternationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
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
    }
}
