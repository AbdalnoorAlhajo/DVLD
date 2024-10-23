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
    public class clsDriversDataAccess
    {
        public static bool IsDriverExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found = 1 from Drivers
                            where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static DataTable GetAllDrivers()

        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT 
    Drivers.DriverID,
    People.PersonID,
    People.NationalNo,
    (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName) AS fullName,
    People.DateOfBirth,
    COUNT(Licenses.DriverID) AS LicenseCount
FROM
    Drivers
INNER JOIN
    People ON Drivers.PersonID = People.PersonID
INNER JOIN
    Licenses ON Licenses.DriverID = Drivers.DriverID
GROUP BY
    Drivers.DriverID,
    People.PersonID,
    People.NationalNo,
    People.FirstName,
    People.SecondName,
    People.ThirdName,
    People.LastName,
    People.DateOfBirth;";

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
        public static int AddDriver(int PersonID
            , int CreatedByUserID, DateTime CreatedDate)
        {

            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Drivers
(PersonID, CreatedByUserID, CreatedDate)
 VALUES  (@PersonID, @CreatedByUserID, @CreatedDate);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
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


            return DriverID;
        }

        static public bool FindDriverByPersonID(ref int DriverID, int PersonID
            , ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Drivers where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    DriverID = (int)reader["DriverID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        static public bool FindDriverByDriverID(ref int DriverID, ref int PersonID
    , ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Drivers where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    PersonID = (int)reader["PersonID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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
