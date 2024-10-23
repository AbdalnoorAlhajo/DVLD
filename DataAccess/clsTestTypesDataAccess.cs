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
    public class clsTestTypesDataAccess
    {
        static public DataTable GetAllTestTypes()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from TestTypes";

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

        static public decimal GetTestFees(int TestTypeID)
        {
            decimal TestFees = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TestTypeFees from TestTypes 
                                where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue
                ("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && decimal.TryParse(result.ToString()
                    , out decimal Fees))
                {
                    TestFees = Fees;
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


            return TestFees;
        }


        static public bool FindTestTypeByID(ref int TestTypeID
            , ref string TestTypeTitle, ref string TestTypeDescription, ref Decimal TestTypeFees)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestTypes
                where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isExists = true;

                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = Convert.ToDecimal(reader["TestTypeFees"]);
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


        public static bool UpdateTestType(int TestTypeID
            , string TestTypeTitle, string TestTypeDescription, Decimal TestTypeFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  TestTypes  
                            set TestTypeTitle = @TestTypeTitle,
                                TestTypeFees = @TestTypeFees,
                                TestTypeDescription = @TestTypeDescription
                                where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

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
