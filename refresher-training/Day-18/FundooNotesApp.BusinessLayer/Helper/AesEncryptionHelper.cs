using System.Security.Cryptography;
using System.Text;

namespace FundooNotesApp.BusinessLayer.Helper
{
    public class AesEncryptionHelper
    {
        private readonly byte[] _key;
        private readonly byte[] _iv;

        // key and iv must be 32 and 16 bytes respectively for AES-256
        public AesEncryptionHelper(string key, string iv)
        {
            _key = Encoding.UTF8.GetBytes(key);
            _iv = Encoding.UTF8.GetBytes(iv);
        }

        public string Encrypt(string plainText)
        {
            using var aes = Aes.Create();
            aes.Key = _key;
            aes.IV = _iv;
            using var encryptor = aes.CreateEncryptor();
            byte[] input = Encoding.UTF8.GetBytes(plainText);
            byte[] result = encryptor.TransformFinalBlock(input, 0, input.Length);
            return Convert.ToBase64String(result);
        }

        public string Decrypt(string cipherText)
        {
            using var aes = Aes.Create();
            aes.Key = _key;
            aes.IV = _iv;
            using var decryptor = aes.CreateDecryptor();
            byte[] input = Convert.FromBase64String(cipherText);
            byte[] result = decryptor.TransformFinalBlock(input, 0, input.Length);
            return Encoding.UTF8.GetString(result);
        }
    }
}