using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Image_Encryption
{
    public class clsEncryption
    {
       public static void EncryptFile(string inputFile, string outputFile, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                {
                    // Write the IV to the beginning of the file
                    fsOutput.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
                {
                    // Skip the IV at the beginning of the file
                    fsInput.Seek(aesAlg.IV.Length, SeekOrigin.Begin);
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }

    }
}
