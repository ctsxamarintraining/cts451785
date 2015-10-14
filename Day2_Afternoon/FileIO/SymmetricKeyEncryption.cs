using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace FileIO
{
    class SymmetricKeyEncryption
    {
        public static void encryptAndDecrypt()
        {
            try
            {
                Console.WriteLine("Enter text to encrypt:");
                string text = Console.ReadLine();
                //Encrypt
                DESCryptoServiceProvider key = new DESCryptoServiceProvider();
                byte[] buffer = Encrypt(text, key);
                //write to file
                System.IO.File.WriteAllBytes(@"C:\Users\451785\Documents\Visual Studio 2012\Projects\FileIO\encyptedText.txt", buffer);

                //read text from file to decrypt
                byte[] buferToDecrypt = File.ReadAllBytes(@"C:\Users\451785\Documents\Visual Studio 2012\Projects\FileIO\encyptedText.txt");
                string strText = Decrypt(buferToDecrypt, key);
                Console.WriteLine("\nDecrypted text:"+strText);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
        public static byte[] Encrypt(string strText, SymmetricAlgorithm key)
        {
            // Create a memory stream.
            MemoryStream ms = new MemoryStream();

            // Create a CryptoStream using the memory stream and the
            // CSP(cryptoserviceprovider) DES key.
            CryptoStream crypstream = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);

            // Create a StreamWriter to write a string to the stream.
            StreamWriter sw = new StreamWriter(crypstream);

            // Write the strText to the stream.
            sw.WriteLine(strText);

            // Close the StreamWriter and CryptoStream.
            sw.Close();
            crypstream.Close();

            // Get an array of bytes that represents the memory stream.
            byte[] buffer = ms.ToArray();

            // Close the memory stream.
            ms.Close();

            // Return the encrypted byte array.
            return buffer;
        }
        public static string Decrypt(byte[] encryptText, SymmetricAlgorithm key)
        {
            // Create a memory stream to the passed buffer.
            MemoryStream ms = new MemoryStream(encryptText);
            // Create a CryptoStream using  memory stream and CSP DES key.
            CryptoStream crypstream = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);

            // Create a StreamReader for reading the stream.
            StreamReader sr = new StreamReader(crypstream);

            // Read the stream as a string.
            string val = sr.ReadLine();

            // Close the streams.
            sr.Close();
            crypstream.Close();
            ms.Close();

            return val;
        }
    }
}
