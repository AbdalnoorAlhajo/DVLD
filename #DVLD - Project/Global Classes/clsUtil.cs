using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


public class clsUtil
{
    public static bool CreateFolderIfDoesNotExist(string FolderPath)
    {
        if (!Directory.Exists(FolderPath))
        {
            try
            {
                Directory.CreateDirectory(FolderPath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

           
        }
        return true;
    }

    public static string ReplaceFileNameWithGUID(string sourceFile)
    {
        string fileName = sourceFile;
        FileInfo fileInfo = new FileInfo(fileName);

        return Guid.NewGuid().ToString() + fileInfo.Extension;
    }

    public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
    {
        string DestinationFolder = @"C:\DVLD-People-Images\";

        if(!CreateFolderIfDoesNotExist(DestinationFolder))
            return false;

        DestinationFolder += ReplaceFileNameWithGUID(sourceFile);

        try
        {
            File.Copy(sourceFile, DestinationFolder, true);

        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }

        sourceFile = DestinationFolder;
        return true;
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

