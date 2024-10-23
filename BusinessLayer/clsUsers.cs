using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsUsers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int PersonID { get; set; }
        public bool IsActive { get; set; }

        private clsUsers(int ID, string UserName, string PassWord, int PersonID, bool IsActive)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = PassWord;
            this.PersonID = PersonID;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        public clsUsers()
        {
            ID = -1;
            UserName = "";
            Password = "";
            PersonID = -1;
            IsActive = false;
            Mode = enMode.AddNew;
        }

        static public clsUsers Find(string UserName, string Password)
        {
            int PersonID = -1, ID = -1;
            bool IsActive = false, isFound = false;

            isFound = clsUsersDataAccess.FindUserByUsernameAndPassword(ref ID, ref UserName, ref Password
                , ref PersonID, ref IsActive);


            if (isFound)
                return new clsUsers(ID, UserName, Password, PersonID, IsActive);
            else
                return null;
        }

        static public clsUsers FindByID(int PersonID)
        {
            string UserName = "", Password = "";
            int UserID = -1;
            bool IsActive = false, isFound = false;

            isFound = clsUsersDataAccess.FindUserByID(ref UserID, ref UserName, ref Password
                , ref PersonID, ref IsActive);


            if (isFound)
                return new clsUsers(UserID, UserName, Password, PersonID, IsActive);
            else
                return null;
        }

        static public clsUsers FindByUserID(int UserID)
        {
            string UserName = "", Password = "";
            int PersonID = -1;
            bool IsActive = false, isFound = false;

            isFound = clsUsersDataAccess.FindUserByUserID(ref UserID, ref UserName, ref Password
                , ref PersonID, ref IsActive);


            if (isFound)
                return new clsUsers(UserID, UserName, Password, PersonID, IsActive);
            else
                return null;
        }

        bool _AddNewUser()
        {

            this.ID = clsUsersDataAccess.AddNewUser(this.UserName, this.Password, this.PersonID
               , this.IsActive);

            return (this.ID > 0);
        }

        bool _UpdateUser()
        {
            return clsUsersDataAccess.UpdateUser(this.ID, this.UserName, this.Password
                , this.IsActive);
        }

        static public bool IsUserExists(string UserName)
        {
            return clsUsersDataAccess.IsUserNameExists(UserName);
        }

        static public bool IsUserExists(int PersonID)
        {
            return clsUsersDataAccess.IsUserNameExists(PersonID);
        }

        static public bool DeleteUser(int UserID)
        {
            return clsUsersDataAccess.DeleteUser(UserID);
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }




            return false;
        }

        static public DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }
    }

}
