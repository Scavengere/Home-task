using System;
using System.Text;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToEncrypt = Console.ReadLine();
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(stringToEncrypt);
            Encryption encryption = new Encryption();
            byte[] encryptedData = encryption.Encrypt(dataToEncrypt);
            byte[] decryptedData = encryption.Decrypt(encryptedData);
            Console.WriteLine(ByteConverter.GetString(encryptedData));
            Console.WriteLine(ByteConverter.GetString(decryptedData));
            Console.ReadLine();
        }
    }
}
