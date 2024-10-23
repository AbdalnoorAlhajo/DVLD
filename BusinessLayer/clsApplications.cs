using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ApplicationID { get; set; }

        public clsPeople Person { get; set; }

        public int ApplicantID { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }

        public DateTime ApplicationStatusDate { get; set; }

        public decimal PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        public enum enApplicationStatuses { New = 1, Completed = 3, Canceled = 2, Update = 4 };

        public enApplicationStatuses ApplicationStatus { get; set; }


        public clsApplications()
        {
            ApplicationID = -1;
            ApplicantID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationStatusDate = DateTime.Now;
            ApplicationTypeID = 0;
            ApplicationStatus = enApplicationStatuses.New;
            PaidFees = -1;
            CreatedByUserID = -1;
            Person = null;
            Mode = enMode.AddNew;
        }

        public clsApplications(int ApplicationID, int ApplicantID, DateTime ApplicationDate
            , int ApplicationTypeID, enApplicationStatuses ApplicationStatus, DateTime ApplicationStatusDate
            , decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantID = ApplicantID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.ApplicationStatusDate = ApplicationStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.Person = clsPeople.Find(ApplicantID);

            Mode = enMode.Update;
        }


        public DataTable GetAllApplications()
        {
            return clsApplicationsDataAccess.GetAllApplications();
        }

        private int ConvertFromStatusToInt(enApplicationStatuses ApplicationStatues)
        {
            switch (ApplicationStatues)
            {
                case enApplicationStatuses.New:
                    return 1;
                case enApplicationStatuses.Canceled:
                    return 2;
                case enApplicationStatuses.Completed:
                    return 3;
                default:
                    return -1;
            }
        }

        static public enApplicationStatuses ConvertFromIntToStatus(int ApplicationStatues)
        {
            switch (ApplicationStatues)
            {
                case 1:
                    return enApplicationStatuses.New;
                case 2:
                    return enApplicationStatuses.Canceled;
                case 3:
                    return enApplicationStatuses.Completed;
                default:
                    return enApplicationStatuses.Update;
            }
        }
        bool _UpdateApplication()
        {
            return clsApplicationsDataAccess.UpdateApplication(this.ApplicationID, this.ApplicantID
                , this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatusDate
                , this.PaidFees, this.CreatedByUserID
                , ConvertFromStatusToInt(this.ApplicationStatus));
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationsDataAccess.DeleteApplication(ApplicationID);
        }

        public static bool IsApplicationExists(int ApplicationID)
        {
            return clsApplicationsDataAccess.IsApplicationExists(ApplicationID);
        }

        public static bool IsNewApplication(int ApplicantPersonID, int ApplicationTypeID)
        {
            return clsApplicationsDataAccess.IsNewApplication(ApplicantPersonID
                , ApplicationTypeID);
        }

        public static clsApplications FindApplication(int ApplicationID)
        {
            int ApplicantID = -1, ApplicationTypeID = -1
                , CreatedByUserID = -1, ApplicationStatus = -1;
            DateTime ApplicationDate = DateTime.Now, ApplicationStatusDate = DateTime.Now;
            decimal PaidFees = -1;

            if (clsApplicationsDataAccess.FindApplicationByID(ref ApplicationID
                , ref ApplicantID, ref ApplicationDate, ref ApplicationTypeID
                , ref ApplicationStatusDate
                , ref PaidFees, ref CreatedByUserID, ref ApplicationStatus))
            {
                return new clsApplications(ApplicationID, ApplicantID
                   , ApplicationDate, ApplicationTypeID
                   , ConvertFromIntToStatus(ApplicationStatus)
                   , ApplicationStatusDate, PaidFees, CreatedByUserID);
            }
            else
                return null;
        }

        public static bool UpdateApplicationStatus(int ApplicationID, int NewStatus)
        {
            return clsApplicationsDataAccess.UpdateApplicationStatus(ApplicationID,
               NewStatus);
        }


        bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationsDataAccess.AddNewApplication(this.ApplicantID,
                this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatusDate
     , this.PaidFees, this.CreatedByUserID, ConvertFromStatusToInt(this.ApplicationStatus));

            return (this.ApplicationID > 0);
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }




            return false;
        }

    }
}
