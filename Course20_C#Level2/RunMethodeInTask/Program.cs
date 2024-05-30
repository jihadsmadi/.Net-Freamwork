using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RunMethodeInTask
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			Task task1 = Task.Run(() => DownloadFile("Git Repo"));
			Task task2 = Task.Run(() => DownloadFile("Network Book"));

			await Task.WhenAll(task1, task2);
			Console.WriteLine("Task1 and task2 completed");
			Console.ReadKey();
		}

		static void DownloadFile(string fileName)
		{
			Console.WriteLine($"{fileName} Start Execete ");
			Thread.Sleep(5000);

			Console.WriteLine($"{fileName} Complete Download");
		}
	}
}
