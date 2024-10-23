using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLocalApplications : clsApplications
    {
        public int LocalDrivingLicenseApplicationID { get; set; }

        public int LicenseClassID { get; set; }

        public clsLocalApplications()
        {
            this.LocalDrivingLicenseApplicationID = 0;
            this.LicenseClassID = 0;
        }
        public clsLocalApplications(int ApplicationID,
            int LocalDrivingLicenseApplicationID, int LicenseClassID)
        {
            this.ApplicationID = ApplicationID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
        }
        public clsLocalApplications(int ApplicationID, int ApplicantID, DateTime ApplicationDate
            , int ApplicationTypeID, enApplicationStatuses ApplicationStatus
            , DateTime ApplicationStatusDate, decimal PaidFees, int CreatedByUserID,
            int LocalDrivingLicenseApplicationID, int LicenseClassID) : base
            (ApplicationID, ApplicantID, ApplicationDate, ApplicationTypeID
            , ApplicationStatus, ApplicationStatusDate, PaidFees, CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
        }

        public static DataTable GetAllLocalApplicationsName()
        {
            return clsLocalApplicationsDataAccess.GetAllLocalApplicationsName();
        }

        public static DataTable GetAllDataForManageLocalApplications()
        {
            return clsLocalApplicationsDataAccess.GetAllDataForManageLocalApplications();
        }

        public static bool IsDriverPassedTest(int LocalDrivingLicenseApplicationID
            , int TestTypeID)
        {
            int LastTestAppointmentID = clsTestAppointments.GetLastTestAppointmentID
                (LocalDrivingLicenseApplicationID, TestTypeID);

            if (LastTestAppointmentID > 0 && clsTests.IsTestExistAndPass
                    (LastTestAppointmentID))
                return true;
            else
                return false;
        }

        public static bool IsPersonWithLicenseClassIDExists(int ApplicantPersonID
            , int LicenseClassID)
        {
            return clsLocalApplicationsDataAccess.IsLocalApplicationExists(
                ApplicantPersonID, LicenseClassID);
        }

        public static int GetPassedTests(int LocalDrivingLicenceApplicationID)
        {
            return clsLocalApplicationsDataAccess.GetPassedTest
                (LocalDrivingLicenceApplicationID);
        }
        public static bool DeleteApplication(int LocalDrivingLicenceApplicationID)
        {
            clsLocalApplications LApp = clsLocalApplications.FindLocalApplication
                (LocalDrivingLicenceApplicationID);

            if (clsLocalApplicationsDataAccess.DeleteApplication
                (LocalDrivingLicenceApplicationID))
            {
                return clsApplications.DeleteApplication(LApp.ApplicationID);
            }
            else
                return false;

        }
        bool _AddNewLocalApplication()
        {
            LocalDrivingLicenseApplicationID =
    clsLocalApplicationsDataAccess.AddNewApplication(this.ApplicationID,
    this.LicenseClassID);

            return (LocalDrivingLicenseApplicationID > -1);
        }

        bool _UpdateLocalApplication()
        {
            // return clsLocalApplicationsDataAccess.UpdateLocalApplication

            return false;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return (base.Save() && _AddNewLocalApplication());
                case enMode.Update:
                    return (base.Save() && _UpdateLocalApplication());
                default:
                    return false;
            }
        }

        public static clsLocalApplications FindApplication(int ApplicationID)
        {
            clsApplications Ap
                = clsApplications.FindApplication(ApplicationID);

            int LocalDrivingLicenceID = -1, LicenceID = -1;

            if (clsLocalApplicationsDataAccess.FindLocalApplicationByApplicationID(
                 Ap.ApplicationID, ref LocalDrivingLicenceID, ref LicenceID))
            {
                return new clsLocalApplications(Ap.ApplicationID, Ap.ApplicantID
                    , Ap.ApplicationDate, Ap.ApplicationTypeID, Ap.ApplicationStatus
                    , Ap.ApplicationStatusDate, Ap.PaidFees, Ap.CreatedByUserID
                    , LocalDrivingLicenceID, LicenceID);
            }
            else
                return null;
        }

        public static clsLocalApplications FindLocalApplication(int LocalApplicationID)
        {

            int ApplicationID = -1, LicenceID = -1;

            if (clsLocalApplicationsDataAccess.FindLocalApplicationByLocalApplicationID
                (ref ApplicationID, LocalApplicationID, ref LicenceID))
            {
                clsApplications Ap = clsApplications.FindApplication(ApplicationID);
                return new clsLocalApplications(Ap.ApplicationID, Ap.ApplicantID
                     , Ap.ApplicationDate, Ap.ApplicationTypeID, Ap.ApplicationStatus
                     , Ap.ApplicationStatusDate, Ap.PaidFees, Ap.CreatedByUserID
                     , LocalApplicationID, LicenceID);
            }
            else
                return null;

        }
    }

}
