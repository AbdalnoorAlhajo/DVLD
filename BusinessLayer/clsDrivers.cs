using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDrivers
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
        }

        clsDrivers(int driverID, int personID, int createdByUserID
            , DateTime createdDate)
        {
            this.DriverID = driverID;
            this.PersonID = personID;
            this.CreatedByUserID = createdByUserID;
            this.CreatedDate = createdDate;
        }
        public static DataTable GetAllDrivers()
        {
            return clsDriversDataAccess.GetAllDrivers();
        }
        public static bool IsDriverExist(int PersonID)
        {
            return clsDriversDataAccess.IsDriverExist(PersonID);
        }

        static public clsDrivers FindDriverByPersonID(int PersonID)
        {
            int driverID = -1, createdByUserID = -1;
            DateTime createdDate = DateTime.Now;

            if (clsDriversDataAccess.FindDriverByPersonID(ref driverID, PersonID
                , ref createdByUserID, ref createdDate))
            {
                return new clsDrivers(driverID, PersonID, createdByUserID, createdDate);
            }
            else
                return null;
        }

        static public clsDrivers FindDriverByDriverID(int driverID)
        {
            int PersonID = -1, createdByUserID = -1;
            DateTime createdDate = DateTime.Now;

            if (clsDriversDataAccess.FindDriverByDriverID(ref driverID, ref PersonID
                , ref createdByUserID, ref createdDate))
            {
                return new clsDrivers(driverID, PersonID, createdByUserID, createdDate);
            }
            else
                return null;
        }

        public bool AddNewDriver()
        {
            this.DriverID = clsDriversDataAccess.AddDriver(this.PersonID
                , this.CreatedByUserID, this.CreatedDate);

            return (this.DriverID > 0);
        }
    }
}
