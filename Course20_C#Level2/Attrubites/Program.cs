/*#define KOKO*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attrubites
{
	internal class Program
	{
		/*If you put a conditional attrubite above a calss,methode or proporte thay will be executed Only In Debug Moode */
		/*[Conditional("DEBUG")]
		static public void Methode1()
		{
			Console.WriteLine("This Is The Methode One");
		}

		static public void Methode2()
		{
			Console.WriteLine("This Is The Methode Two");
		}*/

		/*You should to define koko conditional in top of the file or you can add it from project > propertes > debug > attrubites */
		/*[Conditional("KOKO")]
		static public void Methode1()
		{
			Console.WriteLine("This Is The Methode One");
		}

		static public void Methode2()
		{
			Console.WriteLine("This Is The Methode Two");
		}*/


		/*Tell that the class,methode or properte below the attrubiti this methode will not be there in next version and warrning him*/
		[Obsolete("This Massege will delete in the next versions ...!")]
		static public void Methode1()
		{
			Console.WriteLine("This Is The Methode One");
		}

		static public void Methode2()
		{
			Console.WriteLine("This Is The Methode Two");
		}
		static void Main(string[] args)
		{
			Methode1();
			Methode2();

			Console.ReadKey();
		}
	}
}
