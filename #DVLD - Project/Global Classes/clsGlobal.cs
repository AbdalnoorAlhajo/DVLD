using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DVLD___Project.Global_Classes
{
    internal class clsGlobal
    {
        static public bool RememberUserNameAndPassword(string userName, string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

            try
            {
                Registry.SetValue(keyPath, "userName", userName, RegistryValueKind.String);
                Registry.SetValue(keyPath, "password", password, RegistryValueKind.String);

                return true;

                // Old Code (Storing info into a file)
                //string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                //string FileName = CurrentDirectory + "\\Data.txt";

                //if(userName == "" && File.Exists(FileName))
                //{
                //    File.Delete(FileName);
                //    return true;
                //}

                //string DataToSave = userName + "#//#" + password;

                //using (StreamWriter writer = new StreamWriter(FileName))
                //{
                //    writer.WriteLine(DataToSave);
                //    return true;
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }


        }

        static public bool GetStoredCredential(ref string userName, ref string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            try
            {
                userName = Registry.GetValue(keyPath, "userName", null) as string;
                password = Registry.GetValue(keyPath, "password", null) as string;

                return (!string.IsNullOrEmpty(userName)
                    && !string.IsNullOrEmpty(password));

                // Old Code (retrive info from a file)
                //string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                //string FileName = CurrentDirectory + "\\Data.txt";

                //if(File.Exists(FileName))
                //{
                //    using (StreamReader reader = new StreamReader(FileName))
                //    {
                //        string Line;
                //        if ((Line = reader.ReadLine()) != null)
                //        {
                //            string[] Result = Line.Split(new string[] {"#//#"}
                //            , StringSplitOptions.None);

                //            userName = Result[0];
                //            password = Result[1];
                //            return true;
                //        }
                //    }
                //}
                //return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

        }
    }
}
