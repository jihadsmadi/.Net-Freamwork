using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MultiAsyncTasks
{
	internal class Program
	{
		static async Task Main()
		{
			Task task1 = DownloadWebPageAsync("https://www.youtube.com/");
			Console.WriteLine("Task1 Started");

			Task task2 = DownloadWebPageAsync("https://www.linkedin.com/");
			Console.WriteLine("Task1 Started");

			Task task3 = DownloadWebPageAsync("https://github.com/");
			Console.WriteLine("Task1 Started");

			await Task.WhenAll(task1, task2, task3);
			Console.WriteLine("Complete Programm Execution");
			Console.ReadKey();
		}
		static async Task DownloadWebPageAsync(string url)
		{
			string content = "";

			using(WebClient webClient = new WebClient())
			{
				await Task.Delay(100);

				content = await webClient.DownloadStringTaskAsync(url);
				Console.WriteLine($"{url}: has {content.Length} characters downloaded");
			}
		}
	}
}
