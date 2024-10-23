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

    public class clsDetainedLicensesDataAccess
    {
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT DetainedLicenses.DetainID as 'D.ID', DetainedLicenses.LicenseID as 'L.ID', DetainedLicenses.DetainDate
, DetainedLicenses.IsReleased, DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNo as 'N.No'
, (People.FirstName + ' ' +  People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName) as FullName
, DetainedLicenses.ReleaseApplicationID as ReleaseAppID
FROM     DetainedLicenses 
		inner join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID
		inner join Drivers on Drivers.DriverID = Licenses.DriverID
		inner join People on People.PersonID = Drivers.PersonID";

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

        public static int AddDetainedLicense(int LicenseID, DateTime DetainDate
   , decimal FineFees, bool IsReleased, int CreatedByUserID)
        {

            int DetainID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses(LicenseID, DetainDate
, FineFees, IsReleased, CreatedByUserID)
 VALUES  (@LicenseID, @DetainDate, @FineFees, @IsReleased, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased ? 1 : 0);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
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


            return DetainID;
        }

        static public bool FindByLicenseID(ref int LicenseID, ref int DetainID
         , ref DateTime DetainDate, ref DateTime ReleaseDate, ref decimal FineFees
            , ref bool IsReleased, ref int ReleasedByUserID, ref int ReleaseApplicationID
            , ref int CreatedByUserID)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from DetainedLicenses 
                                    where LicenseID = @LicenseID and IsReleased = 0";

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
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    ReleasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value)
                        ? -1 : (int)reader["ReleasedByUserID"];

                    ReleaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value)
                        ? -1 : (int)reader["ReleaseApplicationID"];

                    ReleaseDate = (reader["ReleaseDate"] == DBNull.Value)
                        ? DateTime.MinValue : (DateTime)reader["ReleaseDate"];

                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (Convert.ToByte(reader["IsReleased"]) == 1)
                        ? true : false;


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


        public static bool UpdateDetainedLicense(int LicenseID, int DetainID
         , DateTime DetainDate, DateTime ReleaseDate, decimal FineFees
            , bool IsReleased, int ReleasedByUserID, int ReleaseApplicationID
            , int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection
                (clsDataAccessSettings.ConnectionString);

            string query = @"Update  DetainedLicenses  
                            set LicenseID = @LicenseID, 
                                DetainDate = @DetainDate, 
                                ReleaseDate = @ReleaseDate,
                                FineFees = @FineFees, 
                                IsReleased = @IsReleased, 
                                ReleasedByUserID = @ReleasedByUserID, 
                                ReleaseApplicationID = @ReleaseApplicationID, 
                                CreatedByUserID = @CreatedByUserID
                                where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased ? 1 : 0);

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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;

            SqlConnection connection = new SqlConnection
                (clsDataAccessSettings.ConnectionString);

            string query = @"select found = 1 from DetainedLicenses
                            where LicenseID = @LicenseID and IsReleased = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsDetained = reader.HasRows;

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
            return IsDetained;
        }
    }
}
