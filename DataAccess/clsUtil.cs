using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


public class clsUtil
{
    public static void SaveToEventLog(string message, EventLogEntryType type)
    {
        string sourceName = "DVLD";

        if (!EventLog.SourceExists(sourceName))
        {
            EventLog.CreateEventSource(sourceName, "Application");
        }

        EventLog.WriteEntry(sourceName, message, type);

    }

    static public string ComputeHash(string input)
    {
        //SHA is Secutred Hash Algorithm.
        // Create an instance of the SHA-256 algorithm
        using (SHA256 sha256 = SHA256.Create())
        {
            // Compute the hash value from the UTF-8 encoded input string
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


            // Convert the byte array to a lowercase hexadecimal string
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }

}

