using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Hashing_Typography
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string data = "Jihad Alsmadi";

			string hashingData = ComputeHashing(data);

			Console.WriteLine("Data =         " + data);
			Console.WriteLine("Hashing Data = " + hashingData);
			Console.WriteLine("Hashing Data Length = " + hashingData.Length);

			Console.ReadKey();
		}

		static public string ComputeHashing(string input)
		{
			using(SHA256 sha256 = SHA256.Create())
			{
				byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

				return BitConverter.ToString(bytes).Replace("-","").ToLower();
			}
		}
	}
}
