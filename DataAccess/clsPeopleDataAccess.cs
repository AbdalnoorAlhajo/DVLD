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
    public class clsPeopleDataAccess
    {


        static public DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT People.PersonID, People.NationalNo
, People.FirstName, People.SecondName, People.ThirdName, People.LastName
, People.DateOfBirth, case when People.Gendor = 0 then 'Male' else 'Female' end
as Gender, People.Address, People.Phone, People.Email, Countries.CountryName
, People.ImagePath FROM     People INNER JOIN                 
Countries ON People.NationalityCountryID = Countries.CountryID";

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

        public static int AddNewContact(string NationalNo, string FirstName, string SecondName,
    string ThirdName, string LastName, string Email, string Phone, string Address, int Gender,
    DateTime DateOfBirth, int NationalityCountryID, string ImagePath)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People 
(NationalNo, FirstName, SecondName, ThirdName, LastName, Email, Phone, Address,DateOfBirth, Gendor, NationalityCountryID,ImagePath)
 VALUES 
(@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @Email, @Phone, @Address,@DateOfBirth, @Gendor, @NationalityCountryID,@ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gender);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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


        public static bool IsPersonExists(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
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

        public static bool IsPersonExists(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from People where PersonID = @PersonID";

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

        public static bool GetPersonInfoByID(ref int ID, ref string NationalNo, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName,
            ref string Email, ref string Phone, ref string Address, ref int Gender,
  ref DateTime DateOfBirth, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";

                    LastName = (string)reader["LastName"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    Gender = Convert.ToInt32(reader["Gendor"]);

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

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

        public static bool GetPersonInfoByNationalNo(ref int ID, ref string NationalNo, ref string FirstName,
    ref string SecondName, ref string ThirdName, ref string LastName,
    ref string Email, ref string Phone, ref string Address, ref int Gender,
ref DateTime DateOfBirth, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";
                    
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    Gender = Convert.ToInt32(reader["Gendor"]);

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

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


        public static bool UpdatePerson(int ID, string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName, string Email, string Phone,
            string Address, int Gender, DateTime DateOfBirth, int NationalityCountryID
            , string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  People  
                            set NationalNo = @NationalNo,
                                FirstName = @FirstName, 
                                SecondName = @SecondName, 
                                ThirdName = @ThirdName,
                                LastName = @LastName, 
                                Email = @Email, 
                                Phone = @Phone, 
                                Address = @Address, 
                                Gendor = @Gender, 
                                DateOfBirth = @DateOfBirth,
                                NationalityCountryID = @NationalityCountryID,
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);

            if (string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


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

        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete People 
                           where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
