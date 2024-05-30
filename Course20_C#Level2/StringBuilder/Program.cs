using System;
using System.Diagnostics;
using System.Text;

namespace String_Builder
{

	internal class Program
	{
		static void Main(string[] args)
		{
			int iteration = 200000;

			//Using Concatination String
			Stopwatch sw = Stopwatch.StartNew();
			ConcatinaionString(iteration);
			sw.Stop();
			Console.WriteLine("Using Concatination String:" + sw.ElapsedMilliseconds);

			//Using String Builder String
			Stopwatch sm = Stopwatch.StartNew();
			stringBuilder(iteration);
			sm.Stop();
			Console.WriteLine(new StringBuilder("Using String Builder ").Append(sm.ElapsedMilliseconds).Append(" ms"));


			Console.ReadKey();
		}
		static void ConcatinaionString(int iteration)
		{
			string result = "";

			for(int i =0;i< iteration; i++)
			{
				result += "a";
			}
		}

		static void stringBuilder(int iteration)
		{
			StringBuilder sb = new StringBuilder();
			for(int i=0;i< iteration;i++)
			{
				sb.Append("a");
			}
		}
	}
}
