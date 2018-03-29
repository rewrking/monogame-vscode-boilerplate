using System;

// Simple logging class based on the environemnt variable
namespace MyGame
{
	public class Log
	{
		bool isDebug;

		public Log()
		{
			isDebug = Environment.GetEnvironmentVariable("BUILD") == "Debug";
		}

		public void Print(String message)
		{
			if (isDebug) {
				Console.Write(message);
			}
		}
	}
}