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
    public class clsUsersDataAccess
    {
        static public bool FindUserByUsernameAndPassword(ref int UserID, ref string UserName, ref string Password
            , ref int PersonID, ref bool IsActive)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where UserName = @UserName
                and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", clsUtil.ComputeHash(Password));

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    if (Convert.ToInt32(reader["IsActive"]) == 0)
                        IsActive = false;
                    else
                        IsActive = true;
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

        static public bool FindUserByID(ref int UserID, ref string UserName, ref string Password
    , ref int PersonID, ref bool IsActive)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    UserID = (int)reader["UserID"];

                    if (Convert.ToInt32(reader["IsActive"]) == 0)
                        IsActive = false;
                    else
                        IsActive = true;
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

        static public bool FindUserByUserID(ref int UserID, ref string UserName, ref string Password
, ref int PersonID, ref bool IsActive)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];

                    if (Convert.ToInt32(reader["IsActive"]) == 0)
                        IsActive = false;
                    else
                        IsActive = true;
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

        static public DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Users";

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

        public static int AddNewUser(string UserName, string Password, int PersonID,
            bool IsActive)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (UserName, Password, PersonID, IsActive)
 VALUES  (@UserName, @Password, @PersonID, @IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", clsUtil.ComputeHash(Password));
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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


            return PersonID;
        }

        public static bool IsUserNameExists(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
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

        public static bool IsUserNameExists(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from Users where PersonID = @PersonID";

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

        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set UserName = @UserName,
                                Password = @Password, 
                                IsActive = @IsActive
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", clsUtil.ComputeHash(Password));
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);

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

        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Users 
                           where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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
