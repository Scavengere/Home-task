using System.IO;
using System.Security.Cryptography;

namespace Task14
{
    class Encryption
    {
        private byte[] encrypted;
        private string publicKey;
        private string privateKey;

        public Encryption()
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                File.WriteAllText("PublicKey.xml", RSA.ToXmlString(false));
                File.WriteAllText("PrivateKey.xml", RSA.ToXmlString(true));
            }
            publicKey = File.ReadAllText("PublicKey.xml");
            privateKey = File.ReadAllText("PrivateKey.xml");
        }

        public byte[] Encrypt(byte[] data)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKey);
                encrypted = RSA.Encrypt(data, false);
            }
            return encrypted;
        }

        public byte[] Decrypt(byte[] data)
        {
            byte[] decrypted;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKey);
                decrypted = RSA.Decrypt(encrypted, false);
            }
            return decrypted;
        }

    }
}
