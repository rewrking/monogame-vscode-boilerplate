using System;

// Simple logging class based on the environemnt variable
namespace MyGame
{
	public struct Log
	{
		public static void Print(String message)
		{
			bool isDebug = Environment.GetEnvironmentVariable("BUILD") == "Debug";
			if (isDebug) {
				Console.Write(message);
			}
		}
	}
}