using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicenses()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = -1;
            IsActive = false;
            IssueReason = 0;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsLicenses(int licenseID, int applicationID, int driverID
            , int licenseClassID, DateTime issueDate, DateTime expirationDate
            , string notes, decimal paidFees, bool isActive, byte issueReason
            , int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClassID = licenseClassID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static clsLicenses FindByApplicationID(int ApplicationID)
        {
            int licenseID = -1, driverID = -1, licenseClassID = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            string notes = "";
            decimal paidFees = -1;
            bool isActive = false;
            byte issueReason = 0;

            if (clsLicensesDataAccess.FindByApplicationID(ref licenseID, ref ApplicationID, ref driverID
                 , ref licenseClassID, ref issueDate, ref expirationDate, ref notes
                 , ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicenses(licenseID, ApplicationID, driverID
                    , licenseClassID, issueDate, expirationDate, notes, paidFees
                    , isActive, issueReason, createdByUserID);

            }
            else
                return null;

        }

        public static clsLicenses FindByLicenseID(int licenseID)
        {
            int ApplicationID = -1, driverID = -1, licenseClassID = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            string notes = "";
            decimal paidFees = -1;
            bool isActive = false;
            byte issueReason = 0;

            if (clsLicensesDataAccess.FindByLicenseID(ref licenseID, ref ApplicationID, ref driverID
                 , ref licenseClassID, ref issueDate, ref expirationDate, ref notes
                 , ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicenses(licenseID, ApplicationID, driverID
                    , licenseClassID, issueDate, expirationDate, notes, paidFees
                    , isActive, issueReason, createdByUserID);

            }
            else
                return null;

        }

        public static DataTable GetLocalLicensesView(int PersonID)
        {
            return clsLicensesDataAccess.GetLocalLicensesView(PersonID);
        }

        static public int GetLocalDrivingLicenseApplicationID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLocalDrivingLicenseApplicationID(LicenseID);
        }

        public static bool IsLicenseExistByApplicationID(int ApplicationID)
        {
            return clsLicensesDataAccess.IsLicenseExistByApplicationID(ApplicationID);
        }

        public static bool IsLicenseExistByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.IsLicenseExistByLicenseID(LicenseID);
        }

        bool _AddNewLicense()
        {
            this.LicenseID = clsLicensesDataAccess.AddLicense(ApplicationID
                , DriverID, LicenseClassID, IssueDate, ExpirationDate
                , Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);

            return (LicenseID > 0);
        }

        bool _UpdateLicense()
        {
            return clsLicensesDataAccess.UpdateLicense(LicenseID, ApplicationID
                , DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees
                , IsActive, IssueReason, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateLicense();

            }
            return false;
        }
    }
}
