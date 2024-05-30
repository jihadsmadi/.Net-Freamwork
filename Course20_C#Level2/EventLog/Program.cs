using System;
using System.Diagnostics;

namespace LogEventInEventViewer
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string sourceName = "JihadApp";

			if(!EventLog.SourceExists(sourceName))
			{
				EventLog.CreateEventSource(sourceName, "Application");
				Console.WriteLine("Create Source Event");
			}

			EventLog.WriteEntry(sourceName,"This Is Information",EventLogEntryType.Information);
			EventLog.WriteEntry(sourceName, "This Is Warning", EventLogEntryType.Warning);
			EventLog.WriteEntry(sourceName,"This Is Error",EventLogEntryType.Error);


			Console.ReadKey();
		}
	}
}
