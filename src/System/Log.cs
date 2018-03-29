using System;

// Simple logging class based on the environemnt variable
namespace MyGame
{
	public struct Log
	{
		public static bool isDebug = Environment.GetEnvironmentVariable("BUILD") == "Debug";

		public static void Print(String message)
		{
			if (isDebug) {
				Console.Write(message);
			}
		}
	}
}