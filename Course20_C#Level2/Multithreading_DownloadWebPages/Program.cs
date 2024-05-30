using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_DownloadWebPages
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Start Threading");

			Thread task1 = new Thread(() => DwonloadAndPrintWebPage("https://www.amazon.com"));
			Console.WriteLine("Start Thread 1");
			task1.Start();

			Thread task2 = new Thread(() => DwonloadAndPrintWebPage("https://www.youtube.com"));
			Console.WriteLine("Start Thread 2");
			task2.Start();

			Thread task3 = new Thread(() => DwonloadAndPrintWebPage("https://www.ProgrammingAdvices.com"));
			Console.WriteLine("Start Thread 3");
			task3.Start();

			task1.Join();
			task2.Join();
			task3.Join();

			Console.WriteLine("Complete Main Threadin ");
			Console.ReadKey();
		}
		public static void DwonloadAndPrintWebPage(string url)
		{
			string content = "";

			using(WebClient webClient = new WebClient())
			{
				Thread.Sleep(100);

				content = webClient.DownloadString(url);
			}

			Console.WriteLine($"{url}: Has {content.Length} Characters ..!");
		}
	}
}
