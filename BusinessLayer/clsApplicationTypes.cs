using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplicationTypes
    {
        public string ApplicationTypeTilte { get; set; }
        public int ApplicationTypeID { get; set; }
        public Decimal ApplicationTypeFees { get; set; }

        public clsApplicationTypes()
        {
            ApplicationTypeID = -1;
            ApplicationTypeFees = -1;
            ApplicationTypeTilte = "";
        }
        private clsApplicationTypes(string applicationTypeTilte, int applicationTypeID
            , Decimal applicationTypeFees)
        {
            this.ApplicationTypeTilte = applicationTypeTilte;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeFees = applicationTypeFees;
        }

        static public DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }

        public bool UpdateApplicationType()
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType(ApplicationTypeID, ApplicationTypeTilte
                , ApplicationTypeFees);
        }

        static public clsApplicationTypes FindApplicationType(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            Decimal ApplicationTypeFees = -1;

            if (clsApplicationTypesDataAccess.FindApplicationTypeByID(ref ApplicationTypeID
                , ref ApplicationTypeTitle, ref ApplicationTypeFees))
                return new clsApplicationTypes(ApplicationTypeTitle, ApplicationTypeID
                    , ApplicationTypeFees);
            else
                return null;
        }

        static public clsApplicationTypes FindApplicationType(string ApplicationTypeTitle)
        {
            int ApplicationTypeID = -1;
            Decimal ApplicationTypeFees = -1;

            if (clsApplicationTypesDataAccess.FindApplicationTypeByName(ref ApplicationTypeID
                , ref ApplicationTypeTitle, ref ApplicationTypeFees))
                return new clsApplicationTypes(ApplicationTypeTitle, ApplicationTypeID
                    , ApplicationTypeFees);
            else
                return null;
        }
    }
}
