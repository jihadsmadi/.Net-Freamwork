using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttrubities
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method ,AllowMultiple =true )]
	public class MyCustomeAttrubiti : System.Attribute
	{
		private string Description;

		public MyCustomeAttrubiti(string description)
		{
			Description = description;
		}
	}
	internal class Program
	{
		[MyCustomeAttrubiti("This Is My Custome Attrubiti")]
		static void Methode1()
		{
			Console.WriteLine("This Is Methode One");
		}
		static void Main(string[] args)
		{
			Methode1();

			Console.ReadKey();
		}
	}
}
