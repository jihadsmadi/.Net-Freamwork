using System;
using System.Threading;


namespace MultithradingProgramming
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Thread t1 = new Thread(()=> Methode1("Thread 1"));
			t1.Start();
		
			Thread t2 = new Thread(()=> Methode2("Thread 2"));
			t2.Start();

			t1.Join();

			t2.Join();

			for (int i = 1;i < 21; i++)
			{
				Console.WriteLine($"\tMain Thrad: {i}");
				Thread.Sleep(500);
			}

			Console.ReadKey();
		}

		static public void Methode1(string threadName)
		{
			for(int i=1;i<11;i++)
			{
				Console.WriteLine($"\t{threadName}:Methode1: {i}");
				Thread.Sleep(500);
			}
		}

		static public void Methode2(string threadName)
		{
			for (int i = 1; i < 11; i++)
			{
				Console.WriteLine($"\t{threadName}:Methode2: {i}");
				Thread.Sleep(500);
			}
		}
	}
}
