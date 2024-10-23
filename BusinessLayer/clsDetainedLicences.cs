using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDetainedLicences
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal FineFees { get; set; }
        public bool IsReleased { get; set; }
        public int ReleaseApplicationID { get; set; }
        public int CreatedByUserID { get; set; }

        public clsDetainedLicences()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            ReleasedByUserID = -1;
            CreatedByUserID = -1;
            FineFees = -1;
            IsReleased = false;
            ReleaseApplicationID = -1;
            Mode = enMode.AddNew;
        }

        clsDetainedLicences(int detainID, int licenseID, DateTime detainDate
            , int releasedByUserID, DateTime releaseDate, decimal fineFees
            , bool isReleased, int releaseApplicationID, int createdByUserID)
        {

            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseDate = releaseDate;
            FineFees = fineFees;
            IsReleased = isReleased;
            ReleaseApplicationID = releaseApplicationID;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicensesDataAccess.IsLicenseDetained(LicenseID);
        }

        static public clsDetainedLicences FindByLicenseID(int LicenseID)
        {
            int detainID = -1, releasedByUserID = -1, releaseApplicationID = -1
                , createdByUserID = -1;
            DateTime releaseDate = DateTime.MinValue, detainDate = DateTime.MinValue;
            decimal fineFees = -1;
            bool isReleased = false;

            if (clsDetainedLicensesDataAccess.FindByLicenseID(ref LicenseID
                , ref detainID, ref detainDate, ref releaseDate, ref fineFees
                , ref isReleased, ref releasedByUserID, ref releaseApplicationID
                , ref createdByUserID))
            {
                return new clsDetainedLicences(detainID, LicenseID, detainDate
                    , releasedByUserID, releaseDate, fineFees, isReleased
                    , releaseApplicationID, createdByUserID);
            }
            else
                return null;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicensesDataAccess.GetAllDetainedLicenses();
        }

        bool _AddDetainedLicence()
        {
            DetainID = clsDetainedLicensesDataAccess.AddDetainedLicense(LicenseID
                , DetainDate, FineFees, IsReleased, CreatedByUserID);

            return (DetainID > 0);
        }

        bool _UpdateDetainedLicence()
        {
            return clsDetainedLicensesDataAccess.UpdateDetainedLicense
                (LicenseID, DetainID, DetainDate, ReleaseDate, FineFees, IsReleased
                , ReleasedByUserID, ReleaseApplicationID, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddDetainedLicence())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateDetainedLicence();

            }
            return false;
        }
    }
}
