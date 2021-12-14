using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApplCryptage
{
    class cryptNet
    {
        //clé symétrique et tableau d'initialisation
        static public byte[] cle = System.Convert.FromBase64String("12UCgcnHy8LHoN/VodosrUVgv+r+kQ5e");
        static public byte[] iv = System.Convert.FromBase64String("AsJNO9N/4dM=");
        

        public static void Generate_cle_iv()
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            byte[] iv = TDES.IV;
            byte[] cle = TDES.Key;

            Console.WriteLine("cle = " + Convert.ToBase64String(cle));
            Console.WriteLine("iv = " + Convert.ToBase64String(iv));
        }

        static public byte[] EncryptSym(string text, byte[] key, byte[] iv)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(text);

            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            // Cet objet est utilisé pour chiffrer les données.
            // Il reçoit en entrée les données en clair sous la forme d'un tableau de bytes.
            // Les données chiffrées sont également retournées sous la forme d'un tableau de bytes
            var encryptor = TDES.CreateEncryptor(key, iv);

            byte[] cryptedTextAsByte = encryptor.TransformFinalBlock(textAsByte, 0, textAsByte.Length);

            return cryptedTextAsByte;
        }
        static public string DecryptSym(byte[] cryptedTextAsByte, byte[] key, byte[] iv)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            // Cet objet est utilisé pour déchiffrer les données.
            // Il reçoit les données chiffrées sous la forme d'un tableau de bytes.
            // Les données déchiffrées sont également retournées sous la forme d'un tableau de bytes
            var decryptor = TDES.CreateDecryptor(key, iv);

            byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

            return Encoding.Default.GetString(decryptedTextAsByte);
        }
    }
   
}
