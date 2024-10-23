using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTests
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public string Notes { get; set; }
        public byte TestResult { get; set; }
        public int CreatedByUserID { get; set; }


        public clsTests()
        {
            TestID = -1;
            TestAppointmentID = -1;
            Notes = "";
            TestResult = 0;
            CreatedByUserID = -1;

        }

        public static bool IsTestExistAndPass(int TestAppointmentID)
        {
            return clsTestsDataAccess.IsTestExistAndPass(TestAppointmentID);
        }

        public static int GetTestID(int TestAppointmentID)
        {
            return clsTestsDataAccess.GetTestID(TestAppointmentID);
        }

        public bool AddNewTest()
        {
            this.TestID = clsTestsDataAccess.AddNewAppointment(this.TestAppointmentID
                , this.TestResult, this.Notes, this.CreatedByUserID);

            if (TestID > 0)
            {
                clsTestAppointments TAppointment
                    = clsTestAppointments.Find(this.TestAppointmentID);
                TAppointment.IsLooked = true;

                TAppointment.Save();
                return true;
            }
            else
                return false;

        }


    }
}
