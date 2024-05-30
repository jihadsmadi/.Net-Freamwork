using System;
using System.Threading.Tasks;

namespace Asynchronus_programming
{
	internal class Program
	{
		static async Task Main()
		{
			Task<int> result = PerformAsyncMethode();

			Console.WriteLine("Complete Runing");

			int result2 =  await  result;

			Console.WriteLine(result2);

			Console.ReadKey();
		}

		static async Task<int> PerformAsyncMethode()
		{
			await Task.Delay(4000);

			// Return a result
			return 42;
		}
	}
}
