using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsInternationalLicenses
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        clsInternationalLicenses(int internationalLicenseID, int applicationID
            , int driverID, int issuedUsingLocalLicenseID, DateTime issueDate
            , DateTime expirationDate, bool isActive, int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }

        public clsInternationalLicenses()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = -1;

        }

        public static clsInternationalLicenses Find(int internationalLicenseID)
        {
            int issuedUsingLocalLicenseID = -1, driverID = -1, ApplicationID = -1
                , createdByUserID = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            bool isActive = false;

            if (clsInternationalLicensesDataAccess.Find(ref internationalLicenseID
                , ref ApplicationID, ref driverID, ref issuedUsingLocalLicenseID
                , ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
            {
                return new clsInternationalLicenses(internationalLicenseID
                    , ApplicationID, driverID, issuedUsingLocalLicenseID, issueDate
                    , expirationDate, isActive, createdByUserID);
            }
            else
                return null;

        }

        public static DataTable GetInternationalLicenseView(int PersonID)
        {
            return clsInternationalLicensesDataAccess.GetInternationalLicenseView
                (PersonID);
        }

        public static DataTable GetAllInternationalLicensesView()
        {
            return clsInternationalLicensesDataAccess.GetAllInternationalLicensesView();
        }


        public bool AddLicense()
        {
            InternationalLicenseID = clsInternationalLicensesDataAccess.AddLicense
                (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate
                , ExpirationDate, IsActive, CreatedByUserID);

            return (InternationalLicenseID > 0);
        }

        public static bool IsLicenseExistByLicenseID(int IssuedUsingLocalLicenseID)
        {
            return clsInternationalLicensesDataAccess.IsLicenseExistByLicenseID
                (IssuedUsingLocalLicenseID);
        }
    }
}
