using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgrammingWithEventExample
{
	class CustomeEventArgs : EventArgs
	{
		public int Varible1 { get; }
		public string Varible2 { get; }

		public CustomeEventArgs(int varible1, string varible2)
		{
			Varible1 = varible1;
			Varible2 = varible2;
		}
	}

	
	internal class Program
	{
		public delegate void CallbackEventHandler(object sender, CustomeEventArgs e);
		// Define an event based on the delegate
		public static event CallbackEventHandler OnCallBackEvent;

		static async Task Main()
		{
			OnCallBackEvent += OnCallbackReceived;

			// Create and run a Task for the asynchronous operation, passing CallbackEvent as a parameter
			Task performTask = PerformAsyncOperation(OnCallBackEvent);

			// Do some other work while waiting for the task to complete
			Console.WriteLine("Doing some other work...");

			// Wait for the task to complete
			await performTask;

			Console.WriteLine("Done!");
			Console.ReadKey();
		}
		static async Task PerformAsyncOperation(CallbackEventHandler callback)
		{
			// Simulate an asynchronous operation
			await Task.Delay(2000);

			// Create event arguments with two parameters
			CustomeEventArgs eventArgs = new CustomeEventArgs(42, "Hello from event");

			// Check if the callback event is not null before invoking
			callback?.Invoke(null, eventArgs);
		}
		static void OnCallbackReceived(object sender, CustomeEventArgs e)
		{
			Console.WriteLine($"Event received: Parameter 1 - {e.Varible1}, Parameter 2 - {e.Varible2}");
		}
	}
}
