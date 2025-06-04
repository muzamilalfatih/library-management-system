using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem.Global_Classes
{
    public class clsUtility
    {
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
        public static bool RememberUsernameAndPassword(string userNameValueData, string passwordValueData)
        {
            
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\LIbraryManagmentSystem";

            string userNameValueName = "UserName";
            string passWordValueName = "Password";
            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, userNameValueName, userNameValueData, RegistryValueKind.String);
                Registry.SetValue(keyPath, passWordValueName, passwordValueData, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }           
        }

        public static bool GetStoredCredential(ref string userName, ref string password)
        {// Specify the Registry key and path
         // string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\LIbraryManagmentSystem";  
            string userNameValueName = "userName";
            string passwordValueName = "Password";

            try
            {
                // Read the value from the Registry
                string userNameValueData = Registry.GetValue(keyPath, userNameValueName,null) as string;
                string passwordValueData = Registry.GetValue(keyPath, passwordValueName, null) as string;


                if (userNameValueData != null && passwordValueData != null)
                {
                    userName = userNameValueData;
                    password = passwordValueData;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static string Encrypt(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);

                /*
                Here, you are setting the IV of the AES algorithm to a block of bytes 
                with a size equal to the block size of the algorithm divided by 8. 
                The block size of AES is typically 128 bits (16 bytes), 
                so the IV size is 128 bits / 8 = 16 bytes.
                 */
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
