using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestAppointments
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreateByUserID { get; set; }
        public bool IsLooked { get; set; }

        public clsTestAppointments()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = -1;
            CreateByUserID = -1;
            IsLooked = false;
            Mode = enMode.AddNew;
        }

        private clsTestAppointments(int testAppointmentID, int testTypeID
            , int localDrivingLicenseApplicationID, DateTime appointmentDate
            , decimal paidFees, int CreateByUserID, bool isLooked)
        {
            this.TestAppointmentID = testAppointmentID;
            this.TestTypeID = testTypeID;
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.AppointmentDate = appointmentDate;
            this.PaidFees = paidFees;
            this.CreateByUserID = CreateByUserID;
            this.IsLooked = isLooked;
            this.Mode = enMode.Update;
        }

        static public DataTable GetAllTestAppointmentsView
            (int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetAllTestAppointmentsView
                (LocalDrivingLicenseApplicationID, TestTypeID);
        }


        static public DateTime GetDateTime(int TestAppointmentID)
        {
            return clsTestAppointmentsDataAccess.GetDateTime(TestAppointmentID);
        }

        static public int GetLastTestAppointmentID(int LocalDrivingLicenseApplicationID
            , int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetLastTestAppointmentID
                (LocalDrivingLicenseApplicationID, TestTypeID);
        }

        static public int GetTrails(int LocalDrivingLicenseApplicationID, int Trails)
        {
            return clsTestAppointmentsDataAccess.GetTrails(LocalDrivingLicenseApplicationID
                , Trails);
        }

        static public clsTestAppointments Find(int testAppointmentID)
        {
            int testTypeID = -1, localDrivingLicenseApplicationID = -1
                , CreateByUserID = -1;
            DateTime appointmentDate = DateTime.Now;
            decimal paidFees = -1;
            bool isLooked = false;

            if (clsTestAppointmentsDataAccess.FindTestAppointmentByTestAppointmentID
               (testAppointmentID, ref testTypeID, ref localDrivingLicenseApplicationID
                , ref appointmentDate, ref paidFees, ref CreateByUserID, ref isLooked))
            {
                return new clsTestAppointments(testAppointmentID, testTypeID
                    , localDrivingLicenseApplicationID, appointmentDate
                    , paidFees, CreateByUserID, isLooked);
            }
            else
                return null;
        }

        static public bool IsTestAppointmentExist(int TestTypeID,
            int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentsDataAccess.IsTestAppointmentExist
                (TestTypeID, LocalDrivingLicenseApplicationID);
        }

        static public bool IsTestAppointmentTaken(int TestAppointmentID)
        {
            return clsTestAppointmentsDataAccess.IsTestAppointmentTaken(TestAppointmentID);
        }

        public bool _AddNewTestAppoitment()
        {
            this.TestAppointmentID = clsTestAppointmentsDataAccess.AddNewAppointment
                (this.TestTypeID, this.LocalDrivingLicenseApplicationID
                , this.AppointmentDate, this.PaidFees, this.CreateByUserID
                , this.IsLooked);

            return (this.TestAppointmentID > 0);
        }

        private bool _UpdateTestAppoitment()
        {
            return clsTestAppointmentsDataAccess.UpdateAppointment(this.TestAppointmentID
                , this.TestTypeID, this.LocalDrivingLicenseApplicationID
                , this.AppointmentDate, this.PaidFees, this.CreateByUserID, this.IsLooked);
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppoitment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppoitment();

            }




            return false;
        }
    }
}
