using System;
using System.Security.Cryptography;
using System.Text;

namespace Symmetric_Encryption
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string OriginalData = "Mhd Jihad Alsmadi";

			string key = "0992129222231120";

			string encryptedData = Encrypt(OriginalData, key);
			string decryptedData = Decrypt(encryptedData, key);
			Console.WriteLine($"Original Data {OriginalData}");
			Console.WriteLine($"Encrypted Data {encryptedData}");
			Console.WriteLine($"Decrypted Data {decryptedData}");

			Console.ReadKey();
		}

		static string Encrypt(string plainText, string key)
		{
			if(key.Length != 16)
			{
				Console.WriteLine("Error,Key Is Not A 128 bit");
				return null;
			}
			using (Aes aesAlg = Aes.Create())
			{
				// Set the key and IV for AES encryption
				aesAlg.Key = Encoding.UTF8.GetBytes(key);
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
		static string Decrypt(string cipherText, string key)
		{
			if (key.Length != 16)
			{
				Console.WriteLine("Error,Key Is Not A 128 bit");
				return null;
			}
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
